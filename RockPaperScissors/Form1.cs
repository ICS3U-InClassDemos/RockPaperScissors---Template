using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

/// <summary>
/// A rock, paper, scissors game that utilizes basic methods
/// for repetitive tasks.
/// </summary>

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        string playerChoice, cpuChoice;

        int wins = 0;
        int losses = 0;
        int ties = 0;
        int choicePause = 1000;
        int outcomePause = 3000;

        Random randGen = new Random();

        SoundPlayer jabPlayer = new SoundPlayer(Properties.Resources.jabSound);
        SoundPlayer gongPlayer = new SoundPlayer(Properties.Resources.gong);

        Image rockImage = Properties.Resources.rock168x280;
        Image paperImage = Properties.Resources.paper168x280;
        Image scissorImage = Properties.Resources.scissors168x280;
        Image winImage = Properties.Resources.winTrans;
        Image loseImage = Properties.Resources.loseTrans;
        Image tieImage = Properties.Resources.tieTrans;

        public Form1()
        {
            InitializeComponent();
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            // Set the playerchoice values
            playerChoice = "rock";
            playerImage.Image = rockImage;

            ComputerTurn();

            // determine winner
            if (cpuChoice == "scissor")
            {
                resultImage.Image = winImage;
                wins++;
                winsLabel.Text = $"Wins: {wins}";
            }
            else if (cpuChoice == "paper")
            {
                resultImage.Image = loseImage;
                losses++;
                lossesLabel.Text = $"Losses: {losses}";
            }
            else
            {
                resultImage.Image = tieImage;
                ties++;
                tiesLabel.Text = $"Ties: {ties}";
            }

            playerImage.Refresh();
            cpuImage.Refresh(); 
            resultImage.Refresh();  
            Thread.Sleep(1000);
            gongPlayer.Play();
           
            Thread.Sleep(2000);
            playerImage.Image = null;
            cpuImage.Image = null;
            resultImage.Image = null;
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            // Set the playerchoice values
            playerChoice = "paper";
            playerImage.Image = paperImage;

            ComputerTurn();

            // determine winner
            if (cpuChoice == "rock")
            {
                resultImage.Image = winImage;
                wins++;
                winsLabel.Text = $"Wins: {wins}";
            }
            else if (cpuChoice == "scissor")
            {
                resultImage.Image = loseImage;
                losses++;
                lossesLabel.Text = $"Losses: {losses}";
            }
            else
            {
                resultImage.Image = tieImage;
                ties++;
                tiesLabel.Text = $"Ties: {ties}";
            }

            playerImage.Refresh();
            cpuImage.Refresh();
            resultImage.Refresh();
            Thread.Sleep(1000);
            gongPlayer.Play();

            Thread.Sleep(2000);
            playerImage.Image = null;
            cpuImage.Image = null;
            resultImage.Image = null;
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            // Set the playerchoice values
            playerChoice = "scissor";
            playerImage.Image = scissorImage;

            ComputerTurn();

            // determine winner
            if (cpuChoice == "paper")
            {
                resultImage.Image = winImage;
                wins++;
                winsLabel.Text = $"Wins: {wins}";
            }
            else if (cpuChoice == "rock")
            {
                resultImage.Image = loseImage;
                losses++;
                lossesLabel.Text = $"Losses: {losses}";
            }
            else
            {
                resultImage.Image = tieImage;
                ties++;
                tiesLabel.Text = $"Ties: {ties}";
            }

            playerImage.Refresh();
            cpuImage.Refresh();
            resultImage.Refresh();
            Thread.Sleep(1000);
            gongPlayer.Play();

            Thread.Sleep(2000);
            playerImage.Image = null;
            cpuImage.Image = null;
            resultImage.Image = null;

        }

        public void ComputerTurn()
        {
            jabPlayer.Play();

            // Set cpu values
            int choice = randGen.Next(1, 4);

            if (choice == 1)
            {
                cpuChoice = "rock";
                cpuImage.Image = rockImage;
            }
            else if (choice == 2)
            {
                cpuChoice = "paper";
                cpuImage.Image = paperImage;
            }
            else
            {
                cpuChoice = "scissor";
                cpuImage.Image = scissorImage;
            }
        }

        public void DetermineWinner()
        {

        }
    }
}