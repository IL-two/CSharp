using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUserWinForm
{
    public partial class AddForm : Form
    {
        private EmployeeAccountingDataSetTableAdapters.Emplayee_tableTableAdapter emplayee_tableTableAdapter;
        private EmpModel empModel;

        public AddForm(EmployeeAccountingDataSetTableAdapters.Emplayee_tableTableAdapter emplayee_tableTableAdapter)
        {
            InitializeComponent();
            this.emplayee_tableTableAdapter = emplayee_tableTableAdapter;            
        }

        public AddForm(EmpModel model, EmployeeAccountingDataSetTableAdapters.Emplayee_tableTableAdapter emplayee_tableTableAdapter)
        {
            InitializeComponent();
            this.Text = "Редактировать";
            this.groupBox1.Text = "Редактирование сотрудника";
                        
            this.AddRowTable.Name = "EditRowTable";
            this.AddRowTable.Text = "Сохранить";
            this.AddRowTable.Click += new System.EventHandler(this.SaveButtonRow_Click);
            this.AddRowTable.Click -= addButtonRow_Click;
            this.emplayee_tableTableAdapter = emplayee_tableTableAdapter;

            empModel = model;

            this.NameTextBox.Text = empModel.Name;
            this.lastNameTextBox.Text = empModel.LastNmae;
            this.PatronymicTextBox.Text = empModel.Patronymic;
            this.SalaryNumeric.Value = empModel.Salary;
        }

        //Редактирование с помощью LINQ
        private void SaveButtonRow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                MessageBox.Show("Пожалуйста введите занчения в поля Имя и Фамилия",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["TestUserWinForm.Properties.Settings.EmployeeAccountingConnectionString"].ConnectionString;
                DataContext dataContext = new DataContext(connectionString);

                Emplayee_table emplayee = dataContext.GetTable<Emplayee_table>().FirstOrDefault(u => u.Id == empModel.Id);
                
                emplayee.FirstName = this.NameTextBox.Text;
                emplayee.LastName = this.lastNameTextBox.Text;
                emplayee.Ptronymic = this.PatronymicTextBox.Text;
                emplayee.Salary = this.SalaryNumeric.Value;

                dataContext.SubmitChanges();

                MessageBox.Show("Данные изменены",
                                "Выполнено",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
        }

        //Добавление с помощью dataGridView
        private void addButtonRow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                MessageBox.Show("Пожалуйста введите занчения в поля Имя и Фамилия",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {                
                emplayee_tableTableAdapter.Insert(lastNameTextBox.Text, NameTextBox.Text, PatronymicTextBox.Text, SalaryNumeric.Value);
                MessageBox.Show("Данные добавлены",
                                "Выполнено",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);                                
                this.Close();
            }
        }
    }
}
