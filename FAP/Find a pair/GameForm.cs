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
    public partial class GameForm : Form
    {
        SampleContext Context = new SampleContext();

        int difficult = 16;
        int lavel = 1;
        int score = 0;
        int bestScore = 0;

        Label firstClicked = null;
        Label secondClicked = null;
        
        Random random = new Random();

        List<string> icons = new List<string>();
        public GameForm()
        {
            InitializeComponent();

            CreateRandomsList();

            CreateRandomsIcons();

            AutorForm f = new AutorForm();
            f.ShowDialog();            

            bestScore = GameUser.gameUserMaxScore;

            bestScoreLabel.Text = bestScore.ToString();

            playerNameLabel.Text = GameUser.gameUserLogin;
                        
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) return;

            Label clickLabel = sender as Label;

            if (clickLabel != null)
            {                
                if (clickLabel.ForeColor == Color.Black) return;

                if (firstClicked == null)
                {
                    firstClicked = clickLabel;
                    clickLabel.ForeColor = Color.Black;

                    return;
                }

                secondClicked = clickLabel;
                secondClicked.ForeColor = Color.Black;                

                if (firstClicked.Text == secondClicked.Text)
                {
                    progressBar1.Value += 1;

                    CheckForWinner();

                    firstClicked = null;
                    secondClicked = null;

                    ScoreGame();

                    BestScoreUser();

                    return;
                }              

                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = BackColor;
            secondClicked.ForeColor = BackColor;
            
            firstClicked = null;
            secondClicked = null;
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            score = 0;
            lavel = 1;

            ScoreLabel.Text = "0";
            lavelLabel.Text = "1";

            NewGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == BackColor)
                        return;
                }
            }

            DialogResult dialogResult = MessageBox.Show("You matched all the icons", "Congratulations", MessageBoxButtons.RetryCancel);

            if (dialogResult == DialogResult.Retry)
            {
                lavel++;
                lavelLabel.Text = lavel.ToString();

                NewGame();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                Close();
            }
        }

        private void ScoreGame()
        {
            score++;
            ScoreLabel.Text = score.ToString();

            if (bestScore < score)
            {
                bestScore = score;
                bestScoreLabel.Text = bestScore.ToString();
            }
        }
        private void CreateRandomsIcons()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconlabel = control as Label;

                if (iconlabel != null)
                {
                    int randomNumber = random.Next(icons.Count);

                    iconlabel.Text = icons[randomNumber];
                    iconlabel.ForeColor = BackColor;
                    //iconlabel.Visible = false;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private string GetSynbolsRandom()
        {
            string symbols = "bBwryYUpghjkzZxnN!@$%";

            int index = random.Next(symbols.Length);

            return symbols[index].ToString();

        }
        private void CreateRandomsList()
        {
            string symbols = "";

            for (int i = 0; i < difficult; i += 2)
            {
                symbols = GetSynbolsRandom();

                icons.Insert(i, symbols);
                icons.Insert(i + 1, symbols);
            }
        }

        private void NewGame()
        {
            progressBar1.Value = 0;

            CreateRandomsList();

            CreateRandomsIcons();
        }

        private void BestScoreUser()
        {
            User user = Context.Users.Find(GameUser.gameUseId);
            if (bestScore > GameUser.gameUserMaxScore)
            {
                GameUser.gameUserMaxScore = bestScore;
                user.userMaxScore = GameUser.gameUserMaxScore;
                Context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
            }            
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            if (GameUser.gameUserLogin == null)
            {
                MessageBox.Show("Authorization error.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerOptionsForm optionsForm = new PlayerOptionsForm();
            optionsForm.ShowDialog();
        }
    }    
}
