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
            playerChoice = "rock";
            playerImage.BackgroundImage = rockImage;

            CpuTurn();

            gongPlayer.Play();

            if (cpuChoice == "scissors")
            {
                wins++;
                resultImage.BackgroundImage = winImage;
                winsLabel.Text = $"Wins: {wins}";
            }
            else if (cpuChoice == "paper")
            {
                losses++;
                resultImage.BackgroundImage = loseImage;
                lossesLabel.Text = $"Losses: {losses}";
            }
            else
            {
                ties++;
                resultImage.BackgroundImage = tieImage;
                tiesLabel.Text = $"Ties: {ties}";
            }

            Refresh();
            Thread.Sleep(outcomePause);
            resultImage.BackgroundImage = null;
            playerImage.BackgroundImage = null;
            cpuImage.BackgroundImage = null;
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            playerChoice = "paper";
            playerImage.BackgroundImage = paperImage;

            CpuTurn();

            gongPlayer.Play();

            if (cpuChoice == "rock")
            {
                wins++;
                resultImage.BackgroundImage = winImage;
                winsLabel.Text = $"Wins: {wins}";
            }
            else if (cpuChoice == "scissors")
            {
                losses++;
                resultImage.BackgroundImage = loseImage;
                lossesLabel.Text = $"Losses: {losses}";
            }
            else
            {
                ties++;
                resultImage.BackgroundImage = tieImage;
                tiesLabel.Text = $"Ties: {ties}";
            }

            Refresh();
            Thread.Sleep(outcomePause);
            resultImage.BackgroundImage = null;
            playerImage.BackgroundImage = null;
            cpuImage.BackgroundImage = null;
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            playerChoice = "scissors";
            playerImage.BackgroundImage = scissorImage;

            CpuTurn();

            gongPlayer.Play();

            if (cpuChoice == "paper")
            {
                wins++;
                resultImage.BackgroundImage = winImage;
                winsLabel.Text = $"Wins: {wins}";
            }
            else if (cpuChoice == "rock")
            {
                losses++;
                resultImage.BackgroundImage = loseImage;
                lossesLabel.Text = $"Losses: {losses}";
            }
            else
            {
                ties++;
                resultImage.BackgroundImage = tieImage;
                tiesLabel.Text = $"Ties: {ties}";
            }

            Refresh();
            Thread.Sleep(outcomePause);
            resultImage.BackgroundImage = null;
            playerImage.BackgroundImage = null;
            cpuImage.BackgroundImage = null;
        }

        public void CpuTurn()
        {
            int randValue = randGen.Next(1, 4);

            if (randValue == 1)
            {
                cpuChoice = "rock";
                cpuImage.BackgroundImage = rockImage;
            }
            else if (randValue == 2)
            {
                cpuChoice = "paper";
                cpuImage.BackgroundImage = paperImage;
            }
            else
            {
                cpuChoice = "scissors";
                cpuImage.BackgroundImage = scissorImage;
            }
        }
    }
}