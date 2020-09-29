//Полностью сделан вручную без использования VS
//Скомпилирован через csc

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FomrmNew
{
	public partial class Form1 : Form
	{
		public Button button1;
		public Button button2;
		public Button button3;
		public Button button4;
		public Button button5;
		public Button button6;
		public Button button7;
		public Button button8;
		public Button button9;
		public Button buttonSysemMonitorParametrs;
		public Button RestartButtun;
		public Label label1;
		public Label label2;
				
		public Form1()
		{
			InitializeComponent();
		}
		
		private void InitializeComponent()
		{
			this.button1 = new Button();
			this.button2 = new Button();			
			this.button3 = new Button();
			this.button4 = new Button();
			this.button5 = new Button();			
			this.button6 = new Button();
			this.button7 = new Button();
			this.button8 = new Button();			
			this.button9 = new Button();
			this.buttonSysemMonitorParametrs = new Button();
			this.RestartButtun = new Button();
			this.label1 = new Label();
			this.label2 = new Label();
			
			//Настройки для button1
			this.button1.Location = new Point(10, 45);
			this.button1.Size = new Size (100, 100);
			this.button1.Name = "button1";
			this.button1.Text = "";
			this.button1.Font = new Font ("Microsoft Sans Serif" ,42);			
			this.button1.Click += new EventHandler(button1_Click);
			
			//Настройки для button2
			this.button2.Location = new Point(120, 45);
			this.button2.Size = new Size (100, 100);
			this.button2.Name = "button2";
			this.button2.Text = "";
			this.button2.Font = new Font ("Microsoft Sans Serif" ,42);
			this.button2.Click += new EventHandler(button1_Click);	

			//Настройки для button3
			this.button3.Location = new Point(230, 45);
			this.button3.Size = new Size (100, 100);
			this.button3.Name = "button3";
			this.button3.Text = "";
			this.button3.Font = new Font ("Microsoft Sans Serif" ,42);			
			this.button3.Click += new EventHandler(button1_Click);	

			//Настройки для button4
			this.button4.Location = new Point(10, 155);
			this.button4.Size = new Size (100, 100);
			this.button4.Name = "button4";
			this.button4.Text = "";
			this.button4.Font = new Font ("Microsoft Sans Serif" ,42);			
			this.button4.Click += new EventHandler(button1_Click);
			
			//Настройки для button5
			this.button5.Location = new Point(120, 155);
			this.button5.Size = new Size (100, 100);
			this.button5.Name = "button5";
			this.button5.Text = "";
			this.button5.Font = new Font ("Microsoft Sans Serif" ,42);			
			this.button5.Click += new EventHandler(button1_Click);
			
			//Настройки для button6
			this.button6.Location = new Point(230, 155);
			this.button6.Size = new Size (100, 100);
			this.button6.Name = "button6";
			this.button6.Text = "";
			this.button6.Font = new Font ("Microsoft Sans Serif" ,42);			
			this.button6.Click += new EventHandler(button1_Click);
			
			//Настройки для button7
			this.button7.Location = new Point(10, 265);
			this.button7.Size = new Size (100, 100);
			this.button7.Name = "button7";
			this.button7.Text = "";
			this.button7.Font = new Font ("Microsoft Sans Serif" ,42);			
			this.button7.Click += new EventHandler(button1_Click);
			
			//Настройки для button8
			this.button8.Location = new Point(120, 265);
			this.button8.Size = new Size (100, 100);
			this.button8.Name = "button8";
			this.button8.Text = "";
			this.button8.Font = new Font ("Microsoft Sans Serif" ,42);			
			this.button8.Click += new EventHandler(button1_Click);
			
			//Настройки для button9
			this.button9.Location = new Point(230, 265);
			this.button9.Size = new Size (100, 100);
			this.button9.Name = "button9";
			this.button9.Text = "";
			this.button9.Font = new Font ("Microsoft Sans Serif" ,42);			
			this.button9.Click += new EventHandler(button1_Click);
			
			//Настройки для buttonSysemMonitorParametrs			
			this.buttonSysemMonitorParametrs.Text = "Посмотреть параметры окна";
			this.buttonSysemMonitorParametrs.Name = "buttonSysemMonitorParametrs";
			this.buttonSysemMonitorParametrs.Size = new Size (80, 25);
			this.buttonSysemMonitorParametrs.Location = new Point(10, 10);			
			this.buttonSysemMonitorParametrs.Click += new EventHandler(buttonSysemMonitorParametrs_Click);
			
			//Настройки для RestartButtun
			this.RestartButtun.Location = new Point(400, 400);
			this.RestartButtun.Size = new Size (250, 50);
			this.RestartButtun.Name = "RestartButtun";
			this.RestartButtun.Text = "New Game";
			this.RestartButtun.Enabled = false;
			this.RestartButtun.Click += new EventHandler(RestartButtun_Click);
			
			//Настройки для label1
			this.label1.Location = new Point (430, 45);
			this.label1.AutoSize = true;
			this.label1.Name = "label1";
			this.label1.Text = "";
			this.label1.Font = new Font ("Microsoft Sans Serif" ,26);
			
			//Настройки для label2
			this.label2.Location = new Point (400, 125);
			this.label2.AutoSize = true;
			this.label2.Name = "label2";
			this.label2.Text = "";
			this.label2.Font = new Font ("Microsoft Sans Serif" ,172);
									
			//Настройки для Form1		
			this.Name = "Form1";			
			this.Text = "TicTuCToi";
			this.ClientSize = new System.Drawing.Size(700, 500);
			this.MaximizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.buttonSysemMonitorParametrs);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.RestartButtun);
			this.Load += new EventHandler(Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());			
		}
		
		Player1 player1 = new Player1();
		Player2 player2 = new Player2();
		
		public void button1_Click(object sender, EventArgs e)
		{			
			if (player1.Player1Turn == true)
			{				
				label1.Text = "Player 2 turn";
				label2.Text = player2.PlayerText;
				((Button)sender).Text = player1.PlayerText;				
				player2.Player2Turn = true;
				player1.Player1Turn = false;
				
				if (Wins(player1.PlayerText))
				{
					MessageBox.Show("Player 1 WIN");
					Application.Restart();
				}
			}
			else
			{
				label1.Text = "Player 1 turn";
				label2.Text = player1.PlayerText;
				((Button)sender).Text = player2.PlayerText;				
				player2.Player2Turn = false;
				player1.Player1Turn = true;	
				
				if (Wins(player2.PlayerText))
				{
					MessageBox.Show("Player 2 WIN");
					Application.Restart();
				}				
			}
			((Button)sender).Enabled = false;
			
			if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false
				&& button4.Enabled == false && button5.Enabled == false && button6.Enabled == false
				&& button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
			{
				RestartButtun.Enabled = true;
			}
		}
		
		public void Form1_Load(object sender, EventArgs e)
		{			
			label1.Text = "Player 1 turn";
			label2.Text = player1.PlayerText;
			player1.Player1Turn = true;
			player2.Player2Turn = false;
		}
				
		public bool Wins(string text)
		{
			if ((button1.Text == text) && (button2.Text == text) && (button3.Text == text)) 
			{
				return true;
			}
			else if ((button1.Text == text) && (button4.Text == text) && (button7.Text == text))
			{
				return true;
			}
			else if ((button1.Text == text) && (button5.Text == text) && (button9.Text == text))
			{
				return true;
			}
			else if ((button4.Text == text) && (button5.Text == text) && (button6.Text == text))
			{
				return true;
			}
			else if ((button7.Text == text) && (button8.Text == text) && (button9.Text == text))
			{
				return true;
			}
			else if ((button2.Text == text) && (button5.Text == text) && (button8.Text == text))
			{
				return true;
			}
			else if ((button3.Text == text) && (button6.Text == text) && (button9.Text == text))
			{
				return true;
			}
			else if ((button3.Text == text) && (button5.Text == text) && (button7.Text == text))
			{
				return true;
			}
			else return false;
		}
		
		public void RestartButtun_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}
				
		public void buttonSysemMonitorParametrs_Click(object sender, EventArgs e)
		{
			Console.WriteLine("SizeForm Width = {0}, Height = {1}\n" +
                              "SizeLabel_1 Width = {2}, Height = {3}\n" +
                              "SizeLabel_2 Width = {4}, Height = {5}\n" +
                              "---------------------------------", this.Size.Width, this.Size.Height, label1.Width, label1.Height, label2.Width, label2.Height);
		}				
	}

	public class Player1
	{
		public bool Player1Turn;
		public string PlayerText = "X";
	}
	
	public class Player2
	{
		public bool Player2Turn;
		public string PlayerText = "O";
	}
}