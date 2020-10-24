namespace TestUserWinForm
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emplayeetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeAccountingDataSet = new TestUserWinForm.EmployeeAccountingDataSet();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.editEmp = new System.Windows.Forms.Button();
            this.deleteEmp = new System.Windows.Forms.Button();
            this.addEmp = new System.Windows.Forms.Button();
            this.emplayee_tableTableAdapter = new TestUserWinForm.EmployeeAccountingDataSetTableAdapters.Emplayee_tableTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empfirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empptronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empsalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplayeetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAccountingDataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(475, 406);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.emplastNameDataGridViewTextBoxColumn,
            this.empfirstNameDataGridViewTextBoxColumn,
            this.empptronymicDataGridViewTextBoxColumn,
            this.empsalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.emplayeetableBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // emplayeetableBindingSource
            // 
            this.emplayeetableBindingSource.DataMember = "Emplayee_table";
            this.emplayeetableBindingSource.DataSource = this.employeeAccountingDataSet;
            // 
            // employeeAccountingDataSet
            // 
            this.employeeAccountingDataSet.DataSetName = "EmployeeAccountingDataSet";
            this.employeeAccountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.editEmp, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.deleteEmp, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.addEmp, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 327);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(459, 71);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // editEmp
            // 
            this.editEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editEmp.Location = new System.Drawing.Point(40, 38);
            this.editEmp.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.editEmp.Name = "editEmp";
            this.editEmp.Size = new System.Drawing.Size(149, 30);
            this.editEmp.TabIndex = 2;
            this.editEmp.Text = "Редактировать";
            this.editEmp.UseVisualStyleBackColor = true;
            this.editEmp.Click += new System.EventHandler(this.editEmp_Click);
            // 
            // deleteEmp
            // 
            this.deleteEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteEmp.Location = new System.Drawing.Point(269, 3);
            this.deleteEmp.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.deleteEmp.Name = "deleteEmp";
            this.deleteEmp.Size = new System.Drawing.Size(150, 29);
            this.deleteEmp.TabIndex = 1;
            this.deleteEmp.Text = "Удалить";
            this.deleteEmp.UseVisualStyleBackColor = true;
            this.deleteEmp.Click += new System.EventHandler(this.deleteEmp_Click);
            // 
            // addEmp
            // 
            this.addEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEmp.Location = new System.Drawing.Point(40, 3);
            this.addEmp.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.addEmp.Name = "addEmp";
            this.addEmp.Size = new System.Drawing.Size(149, 29);
            this.addEmp.TabIndex = 0;
            this.addEmp.Text = "Добавить";
            this.addEmp.UseVisualStyleBackColor = true;
            this.addEmp.Click += new System.EventHandler(this.addEmp_Click);
            // 
            // emplayee_tableTableAdapter
            // 
            this.emplayee_tableTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Emp_id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // emplastNameDataGridViewTextBoxColumn
            // 
            this.emplastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emplastNameDataGridViewTextBoxColumn.DataPropertyName = "Emp_lastName";
            this.emplastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.emplastNameDataGridViewTextBoxColumn.Name = "emplastNameDataGridViewTextBoxColumn";
            this.emplastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empfirstNameDataGridViewTextBoxColumn
            // 
            this.empfirstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empfirstNameDataGridViewTextBoxColumn.DataPropertyName = "Emp_firstName";
            this.empfirstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.empfirstNameDataGridViewTextBoxColumn.Name = "empfirstNameDataGridViewTextBoxColumn";
            this.empfirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empptronymicDataGridViewTextBoxColumn
            // 
            this.empptronymicDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empptronymicDataGridViewTextBoxColumn.DataPropertyName = "Emp_ptronymic";
            this.empptronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.empptronymicDataGridViewTextBoxColumn.Name = "empptronymicDataGridViewTextBoxColumn";
            this.empptronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empsalaryDataGridViewTextBoxColumn
            // 
            this.empsalaryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empsalaryDataGridViewTextBoxColumn.DataPropertyName = "Emp_salary";
            this.empsalaryDataGridViewTextBoxColumn.HeaderText = "З/П";
            this.empsalaryDataGridViewTextBoxColumn.Name = "empsalaryDataGridViewTextBoxColumn";
            this.empsalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(475, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(696, 551);
            this.MinimumSize = new System.Drawing.Size(379, 416);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplayeetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAccountingDataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EmployeeAccountingDataSet employeeAccountingDataSet;
        private System.Windows.Forms.BindingSource emplayeetableBindingSource;
        private EmployeeAccountingDataSetTableAdapters.Emplayee_tableTableAdapter emplayee_tableTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button addEmp;
        private System.Windows.Forms.Button editEmp;
        private System.Windows.Forms.Button deleteEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empfirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empptronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empsalaryDataGridViewTextBoxColumn;
    }
}

