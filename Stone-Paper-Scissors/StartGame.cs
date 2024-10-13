using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stone_Paper_Scissors
{
    public partial class frmStartGame : Form
    {
        public frmStartGame()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private enum enChoices { Stone = 1, Paper = 2, Scissors = 3 };
        private enum enWinner { Player1 = 1, Computer = 2, Draw = 3 };

        public byte NumberOfRounds { get; set; }
        private byte _ComputerScore = 0;
        private byte _Player1Score = 0;
        private byte _RoundsCounter = 1;
        
        private enWinner IncreaseRoundWinnerByOne_GetRoundWinner_ChangePictures(enChoices Player1Choice, enChoices ComputerChoice)
        {
            switch (Player1Choice)
            {
                case enChoices.Stone:
                    {
                        pbPlayer1Picture.BackgroundImage = Properties.Resources.stone;

                        if (ComputerChoice == enChoices.Paper)
                        {
                            pbComputerPicture.BackgroundImage = Properties.Resources.paper;
                            _ComputerScore++;
                            return enWinner.Computer;
                        }
                        else if (ComputerChoice == enChoices.Scissors)
                        {
                            pbComputerPicture.BackgroundImage = Properties.Resources.scissors;
                            _Player1Score++;
                            return enWinner.Player1;
                        }
                        else
                        {
                            pbComputerPicture.BackgroundImage = Properties.Resources.stone;
                            return enWinner.Draw;
                        }
                           
                    }

                case enChoices.Paper:
                    {
                        pbPlayer1Picture.BackgroundImage = Properties.Resources.paper;

                        if (ComputerChoice == enChoices.Scissors)
                        {
                            pbComputerPicture.BackgroundImage = Properties.Resources.scissors;
                            _ComputerScore++;
                            return enWinner.Computer;
                        }
                        if (ComputerChoice == enChoices.Stone)
                        {
                            pbComputerPicture.BackgroundImage = Properties.Resources.stone;
                            _Player1Score++;
                            return enWinner.Player1;
                        }
                        else
                        {
                            pbComputerPicture.BackgroundImage = Properties.Resources.paper;
                            return enWinner.Draw;
                        }
                            
                    }

                case enChoices.Scissors:
                    {
                        pbPlayer1Picture.BackgroundImage = Properties.Resources.scissors;

                        if (ComputerChoice == enChoices.Stone)
                        {
                            pbComputerPicture.BackgroundImage = Properties.Resources.stone;
                            _ComputerScore++;
                            return enWinner.Computer;
                        }
                        if (ComputerChoice == enChoices.Paper)
                        {
                            pbComputerPicture.BackgroundImage = Properties.Resources.paper;
                            _Player1Score++;
                            return enWinner.Player1;
                        }
                        else
                        {
                            pbComputerPicture.BackgroundImage = Properties.Resources.scissors;
                            return enWinner.Draw;
                        }

                    }
            }
            return enWinner.Draw;
        }
        
        private enChoices GetComputerChoice()
        {
            
            byte NumChoice = (byte)rnd.Next(1, 4);
            enChoices Choice = (enChoices)NumChoice;

            return Choice;
        }

        private void DisablePlayer1Chioces()
        {
            btnStone.Enabled = false;
            btnPaper.Enabled = false;
            btnScissors.Enabled = false;
        }

        private void EnablePlayer1Chioces()
        {
            btnStone.Enabled = true;
            btnPaper.Enabled = true;
            btnScissors.Enabled = true;
        }

        private void Restart()
        {
            _Player1Score = 0;
            _RoundsCounter = 0;
            _ComputerScore = 0;

            lblRoundNumber.Text = string.Empty;
            lblFinalWinner.Text = string.Empty;
        }

        private bool IsEndOfGame()
        {
            return (_RoundsCounter > NumberOfRounds);
        }

        private void GetFinalResults()
        {
            string FinalMessage = string.Empty;

            if(_Player1Score > _ComputerScore)
            {
                FinalMessage = "The Final Winner is Player1";
                lblFinalWinner.BackColor = Color.ForestGreen;
            }
            else if (_Player1Score < _ComputerScore)
            {
                FinalMessage = "The Final Winner is Computer";
                lblFinalWinner.BackColor = Color.Red;
            }
            else
            {
                FinalMessage = "No Winner";
                lblFinalWinner.BackColor = Color.DarkGoldenrod;
            }

            lblFinalWinner.Text = FinalMessage;
            MessageBox.Show(FinalMessage + $"\n\n Player1 Score : {_Player1Score}" + $"\n Computer Score : {_ComputerScore}", 
                "Final Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NextRound()
        {

            pbPlayer1Picture.BackgroundImage = Properties.Resources.question_mark;
            pbComputerPicture.BackgroundImage = Properties.Resources.question_mark;

            lblRoundNumber.Text = _RoundsCounter.ToString();
            pnlScore.BackColor = Color.Transparent;

            if (IsEndOfGame())
            {
                GetFinalResults();
                return;
            }

            EnablePlayer1Chioces();
        }


        private async void ProccessTheRoundWinner(enWinner RoundWinner)
        {

            await Task.Delay(1000);

            switch (RoundWinner)
            {
                case enWinner.Player1:
                    pnlScore.BackColor = Color.LightGreen;
                    break;
                case enWinner.Computer:
                    pnlScore.BackColor = Color.Salmon;
                    break;
                case enWinner.Draw:
                    pnlScore.BackColor = Color.Khaki;
                    break;
            }

            lblPlayer1Score.Text = _Player1Score.ToString();
            lblComputerScore.Text = _ComputerScore.ToString();

            _RoundsCounter++;



            await Task.Delay(1500);

            NextRound();

        }

        private void ProccessTheRound(enChoices Player1Choice)
        {
            DisablePlayer1Chioces();
            

            ProccessTheRoundWinner(IncreaseRoundWinnerByOne_GetRoundWinner_ChangePictures(Player1Choice, GetComputerChoice()));

        }


        private void RestartTheGame()
        {
            _RoundsCounter = 1;
            lblRoundNumber.Text = _RoundsCounter.ToString();

            _Player1Score = 0;
            lblPlayer1Score.Text = _Player1Score.ToString();

            _ComputerScore = 0;
            lblComputerScore.Text = _ComputerScore.ToString();

            lblFinalWinner.Text = string.Empty;
            lblFinalWinner.BackColor = Color.Transparent;

            EnablePlayer1Chioces();
        }


        private void btnStone_Click(object sender, EventArgs e)
        {
            ProccessTheRound(enChoices.Stone);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            ProccessTheRound(enChoices.Paper);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            ProccessTheRound(enChoices.Scissors);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartTheGame();
        }
    }
}
