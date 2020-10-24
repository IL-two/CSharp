using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUserWinForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeAccountingDataSet.Emplayee_table". При необходимости она может быть перемещена или удалена.
            updateData();

        }

        private void addEmp_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(emplayee_tableTableAdapter);

            if (addForm.ShowDialog() == DialogResult.Cancel)
            {
                updateData();
            }
        }

        private void updateData()
        {
            this.emplayee_tableTableAdapter.Fill(this.employeeAccountingDataSet.Emplayee_table);
        }
        
        //Удаление с помощью обычного SQL запроса
        private void deleteEmp_Click(object sender, EventArgs e)
        {
            EmpModel empModel = GetEmpModel();
            
            if (MessageBox.Show("Вы уверены, что хотите удалить:\n\n" + empModel.ToString(),
                                "Удаление",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                deleteRowEmp(empModel.Id);
                updateData();
            }            
        }

        private void deleteRowEmp(int id)
        {            
            string sqlExpression = "DELETE Emplayee_table WHERE Emp_Id = (@id)";
            string connectionString = ConfigurationManager.ConnectionStrings["TestUserWinForm.Properties.Settings.EmployeeAccountingConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlParameter parameter = new SqlParameter("@id", id);

                command.Parameters.Add(parameter);
                command.ExecuteNonQuery();
                connection.Close();
            }            
        }

        private EmpModel GetEmpModel()
        {
            EmpModel emp = new EmpModel((int)dataGridView1["ID", dataGridView1.CurrentRow.Index].Value,
                                        dataGridView1["empfirstNameDataGridViewTextBoxColumn", dataGridView1.CurrentRow.Index].Value.ToString(),
                                        dataGridView1["emplastNameDataGridViewTextBoxColumn", dataGridView1.CurrentRow.Index].Value.ToString(),
                                        dataGridView1["empptronymicDataGridViewTextBoxColumn", dataGridView1.CurrentRow.Index].Value.ToString(),
                                        (decimal)dataGridView1["empsalaryDataGridViewTextBoxColumn", dataGridView1.CurrentRow.Index].Value);

            return emp;
        }

        private void editEmp_Click(object sender, EventArgs e)
        {
            EmpModel empModel = GetEmpModel();

            AddForm addForm = new AddForm(empModel, emplayee_tableTableAdapter);

            if (addForm.ShowDialog() == DialogResult.Cancel)
            {
                updateData();
            }

        }
    }
}
