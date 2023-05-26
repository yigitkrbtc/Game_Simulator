using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadplayer1.ReadOnly = true;
            loadplayer2.ReadOnly = true;
            score1TextBox.ReadOnly = true;
            score2TextBox.ReadOnly = true;
            loadgamebutton.Enabled = false;
            gamescorelabel.Text = " ";
        }

        private void creategamebutton_Click(object sender, EventArgs e)
        {    
            // Validate player names
            string player1Name = player1NameTextBox.Text.Trim();
            string player2Name = player2NameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(player1Name) || string.IsNullOrEmpty(player2Name))
            {
                MessageBox.Show("Player names cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidName(player1Name) || !IsValidName(player2Name))
            {
                MessageBox.Show("Player names can only contain letters, numbers, and spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (player1Name.Length > 20 || player2Name.Length > 20)
            {
                MessageBox.Show("Player names cannot exceed 20 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            if(dialog.ShowDialog()==DialogResult.OK){
                SaveForm(dialog.FileName);
            }

        }

        private void SaveForm(string fileName)
        {
            string player1Name = player1NameTextBox.Text.Trim();
            string player2Name = player2NameTextBox.Text.Trim();
            StringBuilder builder = new StringBuilder();
            builder.Append(","+player1Name);
            builder.Append(","+player2Name);
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                var content = builder.ToString();
                writer.Write(content);
                writer.Close();
            }
            MessageBox.Show("Player information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadgamebutton.Enabled = true;
        }

        private bool IsValidName(string name)
        {
            Regex regex = new Regex("^[a-zA-Z0-9 ]*$");
            return regex.IsMatch(name);
        }

        private void loadgamebutton_Click(object sender, EventArgs e)
        {

            if (!File.Exists("data.txt"))
            {
                MessageBox.Show("Data file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
             
                gamescorelabel.Text = "Waiting...";
                loadplayer1.ReadOnly = true;
                loadplayer2.ReadOnly = true;
                gamescorelabel.Visible = true;
                simulategamebutton.Enabled = true;
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error reading data file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                OpenForm(dialog.FileName);
            }
        }

        private void OpenForm(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    var LineArray = line.Split(',');
                    loadplayer2.Text = LineArray[2];
                    loadplayer1.Text = LineArray[1];
                    

                }
            }
        }

        private void simulategamebutton_Click(object sender, EventArgs e)
        {
            if (player1NameTextBox.Text == "" || player2NameTextBox.Text == "")
            {
                MessageBox.Show("Please create or load a game before starting the simulator.");
                gamescorelabel.Visible = false;
                return;
            }

            creategamebutton.Enabled = false;
            loadgamebutton.Enabled = false;

            int countdown = 10;
            gamescorelabel.Text = "Playing " + countdown.ToString();
            simulategamebutton.Enabled = false;

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (object timerSender, EventArgs timerE) =>
            {
                countdown--;
                if (countdown == 0)
                {
                    Random random = new Random();
                    timer.Stop();
                    int score1 = random.Next(16);
                    int score2 = random.Next(16);
                    score1TextBox.Text = score1.ToString();
                    score2TextBox.Text = score2.ToString();
                    if (score1 > score2)
                    {
                        gamescorelabel.Text = "Result " + player1NameTextBox.Text + " wins";
                    }
                    else if (score2 > score1)
                    {
                        gamescorelabel.Text = "Result " + player2NameTextBox.Text + " wins";
                    }
                    else
                    {
                        gamescorelabel.Text = "Result Tie";
                    }
                    creategamebutton.Enabled = true;
                    loadgamebutton.Enabled = true;
                    simulategamebutton.Enabled = true;
                }
                else
                {
                    gamescorelabel.Text = "Playing " + countdown.ToString();
                }
            };
            timer.Start();
        }
    }
}
