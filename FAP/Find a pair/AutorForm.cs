using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirst;

namespace Find_a_pair
{    
    public partial class AutorForm : Form
    {
        SampleContext Context = new SampleContext();
        
        public AutorForm()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>());

            InitializeComponent();

            //Context.Users.Load();           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (createUserCheckBox.Checked)
            {
                registrationGroupBox.Visible = true;
            }
            else
            {
                registrationGroupBox.Visible = false;
            }
        }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckBox.Checked)
            {
                createdPasswordTextBox.UseSystemPasswordChar = false;
                repeatPassTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                createdPasswordTextBox.UseSystemPasswordChar = true;
                repeatPassTextBox.UseSystemPasswordChar = true;
            }
        }        

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (newLoginTextBox.Text == "")
                {
                    MessageBox.Show("Entre login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (createdPasswordTextBox.Text != repeatPassTextBox.Text)
                {
                    MessageBox.Show("Invalid password entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (createdPasswordTextBox.Text == "" && repeatPassTextBox.Text == "")
                {
                    MessageBox.Show("Invalid password entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (SearchkUser(newLoginTextBox.Text))
                {
                    MessageBox.Show("This username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User user = new User
                {
                    userLogin = this.newLoginTextBox.Text,
                    userPassword = this.repeatPassTextBox.Text,
                    userMaxScore = 0
                };

                Context.Users.Add(user);
                Context.SaveChanges();

                newLoginTextBox.Text = String.Empty;
                createdPasswordTextBox.Text = String.Empty;
                repeatPassTextBox.Text = String.Empty;

                MessageBox.Show("A new user has been created", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                createUserCheckBox.Checked = false;
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error: " + ex.ToString()); 
            }
        }

        private bool SearchkUser(string sear)
        {
            User user = Context.Users.FirstOrDefault(us => us.userLogin == sear);
            if (user == null)
            {
                return false;
            }
            return true;
        }        

        private void applyButton_Click(object sender, EventArgs e)
        {
            User user = Context.Users.FirstOrDefault(us => us.userLogin == loginTextBox.Text);
            if (user != null)
            {
                if (user.userPassword == passwordTextBox.Text)
                {
                    MessageBox.Show("Welcome " + loginTextBox.Text, "Find a pare", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GameUser.gameUseId = user.userID;
                    GameUser.gameUserLogin = user.userLogin;
                    GameUser.gameUserPassword = user.userPassword;
                    GameUser.gameUserMaxScore = user.userMaxScore;
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("The username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }        
    }
}
