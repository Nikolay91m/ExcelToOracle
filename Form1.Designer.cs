namespace ExcelToOracle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fillDBbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openXLSXbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSourceTextBox = new System.Windows.Forms.TextBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chosenFileTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fillDBbutton
            // 
            this.fillDBbutton.Enabled = false;
            this.fillDBbutton.Location = new System.Drawing.Point(15, 322);
            this.fillDBbutton.Name = "fillDBbutton";
            this.fillDBbutton.Size = new System.Drawing.Size(343, 23);
            this.fillDBbutton.TabIndex = 0;
            this.fillDBbutton.Text = "Создать и заполнить БД";
            this.fillDBbutton.UseVisualStyleBackColor = true;
            this.fillDBbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Source:";
            // 
            // openXLSXbutton
            // 
            this.openXLSXbutton.Location = new System.Drawing.Point(283, 8);
            this.openXLSXbutton.Name = "openXLSXbutton";
            this.openXLSXbutton.Size = new System.Drawing.Size(75, 23);
            this.openXLSXbutton.TabIndex = 3;
            this.openXLSXbutton.Text = "Выбрать";
            this.openXLSXbutton.UseVisualStyleBackColor = true;
            this.openXLSXbutton.Click += new System.EventHandler(this.openXLSXbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите xlsx файл:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 176);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataSourceTextBox
            // 
            this.dataSourceTextBox.Location = new System.Drawing.Point(85, 244);
            this.dataSourceTextBox.Name = "dataSourceTextBox";
            this.dataSourceTextBox.Size = new System.Drawing.Size(270, 20);
            this.dataSourceTextBox.TabIndex = 6;
            this.dataSourceTextBox.Text = "XE";
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Location = new System.Drawing.Point(85, 270);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(270, 20);
            this.userIDTextBox.TabIndex = 8;
            this.userIDTextBox.Text = "system";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "User ID:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(85, 296);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(270, 20);
            this.passwordTextBox.TabIndex = 10;
            this.passwordTextBox.Text = "test";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Настройки подключения Oracle:";
            // 
            // chosenFileTextBox
            // 
            this.chosenFileTextBox.Enabled = false;
            this.chosenFileTextBox.Location = new System.Drawing.Point(127, 9);
            this.chosenFileTextBox.Name = "chosenFileTextBox";
            this.chosenFileTextBox.Size = new System.Drawing.Size(150, 20);
            this.chosenFileTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 355);
            this.Controls.Add(this.chosenFileTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataSourceTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openXLSXbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillDBbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fillDBbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openXLSXbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox dataSourceTextBox;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox chosenFileTextBox;
    }
}

