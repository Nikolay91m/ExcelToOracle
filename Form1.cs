using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using OfficeOpenXml;
using System.IO;
using System.Text.RegularExpressions; 

namespace ExcelToOracle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string oradb = String.Format("Data Source={0};User Id={1};Password={2};",
                    dataSourceTextBox.Text, userIDTextBox.Text, passwordTextBox.Text);
                using (var con = new OracleConnection(oradb))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    StringBuilder sbCreate = new StringBuilder();
                    StringBuilder sbInsert = new StringBuilder();
                    sbCreate.Append(@"CREATE TABLE excel ( id NUMBER PRIMARY KEY");
                    sbInsert.Append(@"INSERT INTO excel VALUES (:id");
                    for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                    {
                        string titleRow = dataGridView1.Rows[rows].Cells[1].Value.ToString();
                        string typeRow = dataGridView1.Rows[rows].Cells[2].Value.ToString(); 
                        sbCreate.Append(", ");
                        sbCreate.Append(titleRow);
                        sbCreate.Append(" ");
                        sbCreate.Append(typeRow);
                        sbInsert.Append(", :");
                        sbInsert.Append(titleRow);
                    }
                    sbCreate.Append(")");
                    sbInsert.Append(")");
                    cmd.CommandText = sbCreate.ToString();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    using (ExcelPackage xlPackage = new ExcelPackage(new FileInfo(chosenFileTextBox.Text)))
                    {
                        var myWorksheet = xlPackage.Workbook.Worksheets.First();
                        var totalRows = myWorksheet.Dimension.End.Row;
                        var totalColumns = myWorksheet.Dimension.End.Column;

                        var titles = myWorksheet.Cells[1, 1, 1, totalColumns].Select(c => c.Value == null ? string.Empty : c.Value.ToString());

                        for (int rowNum = 2; rowNum <= totalRows; rowNum++)
                        {
                            var cells = myWorksheet.Cells[rowNum, 1, rowNum, totalColumns].Select(c => c.Value == null ? string.Empty : c.Value.ToString());

                            var sql = sbInsert.ToString();
                            using (var cmdInsert = new OracleCommand(sql, con))
                            {
                                List<OracleParameter> parameters = new List<OracleParameter>();
                                parameters.Add(new OracleParameter("id", rowNum-1));
                                for (int i = 0; i < titles.Count(); i++)
                                {
                                    OracleParameter op = new OracleParameter();
                                    op.ParameterName = titles.ElementAt(i);
                                    string typeRow = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                    if (typeRow == "NUMBER") //Сделать больше типов, сделать покрасивее, разобраться с типами Oracle
                                    {
                                        op.Value = Convert.ToInt32(cells.ElementAt(i));
                                        op.DbType = DbType.Int32;
                                    }
                                    else if (typeRow == "VARCHAR(255)")
                                    {
                                        op.Value = cells.ElementAt(i);
                                        op.DbType = DbType.String;
                                    }
                                    parameters.Add(op);
                                }
                                cmdInsert.Parameters.AddRange(parameters.ToArray());
                                cmdInsert.ExecuteNonQuery();
                            }

                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка: " + exp.Message);
            }

        }

        private void openXLSXbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelPackage xlPackage = new ExcelPackage(new FileInfo(openFileDialog.FileName)))
                    {
                        var myWorksheet = xlPackage.Workbook.Worksheets.First();
                        var totalColumns = myWorksheet.Dimension.End.Column;
                        var titles = myWorksheet.Cells[1, 1, 1, totalColumns].Select(c => c.Value == null ? string.Empty : c.Value.ToString());
                        var values = myWorksheet.Cells[2, 1, 2, totalColumns].Select(c => c.Value == null ? string.Empty : c.Value.ToString());

                        var dt = new DataTable();
                        dt.Columns.Add(new DataColumn("Выбрать", typeof(bool)));
                        dt.Columns.Add(new DataColumn("Название столбца в Excel", typeof(string)));
                        dt.Columns.Add(new DataColumn("Тип столбца в ORACLE", typeof(string)));
                        for (int i = 0; i < titles.Count(); i++ )
                        {
                            DataRow datarow = dt.NewRow();
                            datarow["Выбрать"] = true;
                            datarow["Название столбца в Excel"] = titles.ElementAt(i);
                            if (Regex.IsMatch(values.ElementAt(i), @"^\d+$"))
                                datarow["Тип столбца в ORACLE"] = "NUMBER";
                            else
                                datarow["Тип столбца в ORACLE"] = "VARCHAR(255)";
                            dt.Rows.Add(datarow);
                        }
                        dataGridView1.DataSource = dt;
                        fillDBbutton.Enabled = true;
                        chosenFileTextBox.Text = openFileDialog.FileName;
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Ошибка: " + exp.Message);
                }
            }
        }
    }
}
