namespace TestUserWinForm
{
    partial class AddForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SalaryNumeric = new System.Windows.Forms.NumericUpDown();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AddRowTable = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNumeric)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(361, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление нового сотрудника";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.58824F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 280);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.SalaryNumeric, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.PatronymicTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.NameTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lastNameTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(345, 191);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // SalaryNumeric
            // 
            this.SalaryNumeric.DecimalPlaces = 2;
            this.SalaryNumeric.Location = new System.Drawing.Point(106, 156);
            this.SalaryNumeric.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.SalaryNumeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.SalaryNumeric.Name = "SalaryNumeric";
            this.SalaryNumeric.Size = new System.Drawing.Size(163, 20);
            this.SalaryNumeric.TabIndex = 3;
            this.SalaryNumeric.ThousandsSeparator = true;
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(106, 109);
            this.PatronymicTextBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(163, 20);
            this.PatronymicTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(106, 62);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(163, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(106, 15);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(30, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(30, 15, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчетсво:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(30, 15, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Зарплата:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.AddRowTable, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.back, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 200);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(345, 77);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // AddRowTable
            // 
            this.AddRowTable.Location = new System.Drawing.Point(30, 25);
            this.AddRowTable.Margin = new System.Windows.Forms.Padding(30, 25, 3, 3);
            this.AddRowTable.Name = "AddRowTable";
            this.AddRowTable.Size = new System.Drawing.Size(105, 32);
            this.AddRowTable.TabIndex = 4;
            this.AddRowTable.Text = "Добавить";
            this.AddRowTable.UseVisualStyleBackColor = true;
            this.AddRowTable.Click += new System.EventHandler(this.addButtonRow_Click);
            // 
            // back
            // 
            this.back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back.Location = new System.Drawing.Point(202, 25);
            this.back.Margin = new System.Windows.Forms.Padding(30, 25, 3, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(105, 32);
            this.back.TabIndex = 5;
            this.back.Text = "Отмена";
            this.back.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 309);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNumeric)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown SalaryNumeric;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button AddRowTable;
        private System.Windows.Forms.Button back;
    }
}