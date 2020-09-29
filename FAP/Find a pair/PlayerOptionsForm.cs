using CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_a_pair
{
    public partial class PlayerOptionsForm : Form
    {
        SampleContext Context = new SampleContext();
        public PlayerOptionsForm()
        {
            InitializeComponent();

            passwordPlayerLabel.Visible = false;

            playerNameLabel.Text = "Player name: " + GameUser.gameUserLogin;
            passwordPlayerLabel.Text = "Password: " + GameUser.gameUserPassword;
            maxScoreLabel.Text = "Best score: " + GameUser.gameUserMaxScore.ToString();

            usersDataGridView.DataSource = Context.Users.ToList();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordPlayerLabel.Visible = true;
            }
            else
            {
                passwordPlayerLabel.Visible = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OutUsers()
        {

        }
    }
}
