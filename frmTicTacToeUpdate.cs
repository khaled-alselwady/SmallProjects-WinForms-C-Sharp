using MyFirstWinFormsProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmTicTacToeUpdate : Form
    {
        public frmTicTacToeUpdate()
        {
            InitializeComponent();
        }

        enum enPlayer { Player1, Player2}

        enum enWinner { Player1, Player2, Draw}

        struct stGameStatue
        {
            public byte NumberOfWinningToPlayer1;
            public byte NumberOfWinningToPlayer2;
            public byte NumberOfDraw;
            public byte NumberOfRounds;
            public byte NumberOfClickes;
            public enWinner Winner;
        }

        enPlayer PlayerTurn = enPlayer.Player1;
        stGameStatue GameStatue = new stGameStatue();

        

        private bool PlayAgain = true;
        private bool IsNextRound = false;


        void DisableOptionsScreen()
        {
            gbMode.Visible = false;
            gbName.Visible = false;
            gbLevel.Visible = false;
            gbRounds.Visible = false;
            gbLetter.Visible = false;
            btnOk.Visible = false;
            lblOptions.Visible = false;
        }
      
        void EndableOptionsScreen()
        {
            gbMode.Visible = true;
            gbName.Visible = true;
            gbLevel.Visible = true;
            gbRounds.Visible = true;
            gbLetter.Visible = true;
            btnOk.Visible = true;
            lblOptions.Visible = true;
        }

        void DisableStartMenue()
        {
            lblTicTacToe.Visible = false;
            btnStart.Visible = false;
            btnOptions.Visible = false;
        }

        void EnableStartMenue()
        {
            lblTicTacToe.Visible = true;
            btnStart.Visible = true;
            btnOptions.Visible = true;
        }

        bool CheckAllOptions()
        {
            if ((Convert.ToBoolean(txtNameTwo.Tag) && txtNameTwo.Text == "")) 
            {
                return false;
            }

            if (Convert.ToBoolean(combLevel.Tag) && combLevel.Text == "")
            {
                return false;
            }

            if ((rbOnePlayer.Checked || rbTwoPlayer.Checked) && (txtNameOne.Text != "") 
                && (combRounds.Text != "") && (rbX.Checked || rbO.Checked))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        void EnableGameScreen()
        {
            
            btnLetterPlayerOne.Visible = true;
            btnLetterPlayerTwo.Visible = true;
            lblNameOfPlayerOne.Visible = true;
            lblNameOfPlayerTwo.Visible = true;
            lblWinPlayerOne.Visible = true;
            lblWinPlayerTwo.Visible = true;
            lblDraw.Visible = true;
            lblNumberOfWinningPlayerOne.Visible = true;
            lblNumberOfWinningPlayerTwo.Visible = true;
            lblNumberOfDraw.Visible = true;

            pb1.Visible = true;
            pb2.Visible = true;
            pb3.Visible = true;
            pb4.Visible = true;
            pb5.Visible = true;
            pb6.Visible = true;
            pb7.Visible = true;
            pb8.Visible = true;
            pb9.Visible = true;

            btnLetterPlayerOne.Visible = true;
            btnLetterPlayerTwo.Visible = true;

            pbDesign.Visible = true;

            lblRound.Visible = true;
            lblNumberOfCurrentRound.Visible = true;
            lblSlash.Visible = true;
            lblNumberOfRounds.Visible = true;
        }

        void DisableGameScreen()
        {
            btnLetterPlayerOne.Visible = false;
            btnLetterPlayerTwo.Visible = false;
            lblNameOfPlayerOne.Visible = false;
            lblNameOfPlayerTwo.Visible = false;
            lblWinPlayerOne.Visible = false;
            lblWinPlayerTwo.Visible = false;
            lblDraw.Visible = false;
            lblNumberOfWinningPlayerOne.Visible = false;
            lblNumberOfWinningPlayerTwo.Visible = false;
            lblNumberOfDraw.Visible = false;

            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = false;
            pb4.Visible = false;
            pb5.Visible = false;
            pb6.Visible = false;
            pb7.Visible = false;
            pb8.Visible = false;
            pb9.Visible = false;

            btnLetterPlayerOne.Visible = false;
            btnLetterPlayerTwo.Visible = false;

            pbDesign.Visible = false;

            lblRound.Visible = false;
            lblNumberOfCurrentRound.Visible = false;
            lblSlash.Visible = false;
            lblNumberOfRounds.Visible = false;

            pbCrownPlayerOne.Visible = false;
            pbCrownPlayerTwo.Visible = false;

            ReturnThePictureBoxToTheDefault(pb1);
            ReturnThePictureBoxToTheDefault(pb2);
            ReturnThePictureBoxToTheDefault(pb3);
            ReturnThePictureBoxToTheDefault(pb4);
            ReturnThePictureBoxToTheDefault(pb5);
            ReturnThePictureBoxToTheDefault(pb6);
            ReturnThePictureBoxToTheDefault(pb7);
            ReturnThePictureBoxToTheDefault(pb8);
            ReturnThePictureBoxToTheDefault(pb9);

            lblNameOfPlayerOne.ForeColor = Color.White;
            lblNameOfPlayerTwo.ForeColor = Color.White;

        }

        void RestGameInfo()
        {
            GameStatue.NumberOfWinningToPlayer1 = 0;
            GameStatue.NumberOfWinningToPlayer2 = 0;
            GameStatue.NumberOfClickes = 0;
            GameStatue.NumberOfRounds = 0;
            GameStatue.NumberOfDraw = 0;
            PlayerTurn = enPlayer.Player1;
            IsNextRound = false;
            lblDraw.Text = "Draw";
            lblNameOfPlayerOne.Text = "";
            lblNameOfPlayerTwo.Text = "";
            lblNumberOfCurrentRound.Text = "1";
            lblNumberOfDraw.Text = "0";
            lblNumberOfRounds.Text = "0";
            lblNumberOfWinningPlayerOne.Text = "0";
            lblNumberOfWinningPlayerTwo.Text = "0";
            rbO.Checked = false;
            rbX.Checked = false;
            rbOnePlayer.Checked = false;
            rbTwoPlayer.Checked = false;
            txtNameOne.Text = "";
            txtNameTwo.Text = "";
            combLevel.Text = "";
            combRounds.Text = "";
           

        }

        void ReturnThePictureBoxToTheDefault(PictureBox pb)
        {
            pb.Image = Resources.Black;
            pb.Tag = "?";
            pb.BackColor = Color.Black;
        }

        void NextRound()
        {
            GameStatue.NumberOfRounds++;

            ReturnThePictureBoxToTheDefault(pb1);
            ReturnThePictureBoxToTheDefault(pb2);
            ReturnThePictureBoxToTheDefault(pb3);
            ReturnThePictureBoxToTheDefault(pb4);
            ReturnThePictureBoxToTheDefault(pb5);
            ReturnThePictureBoxToTheDefault(pb6);
            ReturnThePictureBoxToTheDefault(pb7);
            ReturnThePictureBoxToTheDefault(pb8);
            ReturnThePictureBoxToTheDefault(pb9);

            lblNameOfPlayerOne.ForeColor = Color.White;
            lblNameOfPlayerTwo.ForeColor = Color.White;

            if ((GameStatue.NumberOfRounds + 1) % 2 == 0) 
            {
                btnLetterPlayerTwo.Enabled = true;
                btnLetterPlayerOne.Enabled = false;

                IsNextRound = true;

                PlayerTurn = enPlayer.Player2;

            }

            else
            {
                

                IsNextRound = false;
            }

            GameStatue.NumberOfClickes = 0;

            lblNumberOfCurrentRound.Text = (GameStatue.NumberOfRounds + 1).ToString();


        }

        void GoToStartMenue()
        {
            DisableGameScreen();
            EnableStartMenue();
            RestGameInfo();
        }

        bool CheckThreePictureBoxes(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {

            if (pb1.Tag.ToString() != "?" && pb1.Tag == pb2.Tag && pb1.Tag == pb3.Tag)
            {
                pb1.BackColor = Color.GreenYellow;
                pb2.BackColor = Color.GreenYellow;
                pb3.BackColor = Color.GreenYellow;

                if (PlayerTurn == enPlayer.Player2)
                {
                    btnLetterPlayerOne.Enabled = true;
                    btnLetterPlayerTwo.Enabled = false;

                    lblNameOfPlayerOne.ForeColor = Color.Green;
                    lblNameOfPlayerTwo.ForeColor = Color.White;

                    MessageBox.Show($"Winner is Player ( {lblNameOfPlayerOne.Text} )",
                        "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblNumberOfWinningPlayerOne.Text = (Convert.ToByte(lblNumberOfWinningPlayerOne.Text) + 1).ToString();
                    pbCrownPlayerOne.Visible = true;
                    pbCrownPlayerTwo.Visible = false;
                    GameStatue.NumberOfWinningToPlayer1++;

                    if (GameStatue.NumberOfRounds + 1 < Convert.ToByte(combRounds.Text))
                    {
                        btnLetterPlayerOne.Enabled = false;
                        btnLetterPlayerTwo.Enabled = true;

                        NextRound();
                        
                    }

                    else
                    {
                        if (GameStatue.NumberOfWinningToPlayer1 > GameStatue.NumberOfWinningToPlayer2)
                        {
                            pbCrownPlayerOne.Visible = true;
                            pbCrownPlayerTwo.Visible = false;
                            MessageBox.Show("Game Is Done" + Environment.NewLine + $"The Winner is ( {lblNameOfPlayerOne.Text} )",
                                "End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GoToStartMenue();
                            return true;
                        }

                        else if (GameStatue.NumberOfWinningToPlayer1 < GameStatue.NumberOfWinningToPlayer2)
                        {
                            pbCrownPlayerTwo.Visible = true;
                            pbCrownPlayerOne.Visible = false;
                            MessageBox.Show("Game Is Done" + Environment.NewLine + $"The Winner is ( {lblNameOfPlayerTwo.Text} )",
                               "End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GoToStartMenue();
                            return true;
                        }

                        else
                        {
                            pbCrownPlayerTwo.Visible = false;
                            pbCrownPlayerOne.Visible = false;
                            MessageBox.Show("Game Is Done" + Environment.NewLine + "Draw!",
                               "End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GoToStartMenue();
                            return true;
                        }

                    }


                    return true;
                }

                else
                {
                    btnLetterPlayerOne.Enabled = false;
                    btnLetterPlayerTwo.Enabled = true;

                    lblNameOfPlayerTwo.ForeColor = Color.Green;
                    lblNameOfPlayerOne.ForeColor = Color.White;

                    MessageBox.Show($"Winner is Player ( {lblNameOfPlayerTwo.Text} )",
                        "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblNumberOfWinningPlayerTwo.Text = (Convert.ToByte(lblNumberOfWinningPlayerTwo.Text) + 1).ToString();                  
                    pbCrownPlayerTwo.Visible = true;
                    pbCrownPlayerOne.Visible = false;
                    GameStatue.NumberOfWinningToPlayer2++;

                    if (GameStatue.NumberOfRounds + 1 < Convert.ToByte(combRounds.Text))
                    {
                        btnLetterPlayerOne.Enabled = true;
                        btnLetterPlayerTwo.Enabled = false;
                        NextRound();
                    }

                    else
                    {
                        if (GameStatue.NumberOfWinningToPlayer1 > GameStatue.NumberOfWinningToPlayer2)
                        {
                            pbCrownPlayerOne.Visible = true;
                            pbCrownPlayerTwo.Visible = false;
                            MessageBox.Show("Game Is Done" + Environment.NewLine + $"The Winner is ( {lblNameOfPlayerOne.Text} )",
                                "End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GoToStartMenue();
                            return true;
                        }

                        else if (GameStatue.NumberOfWinningToPlayer1 < GameStatue.NumberOfWinningToPlayer2)
                        {
                            pbCrownPlayerTwo.Visible = true;
                            pbCrownPlayerOne.Visible = false;
                            MessageBox.Show("Game Is Done" + Environment.NewLine + $"The Winner is ( {lblNameOfPlayerTwo.Text} )",
                               "End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GoToStartMenue();
                            return true;
                        }

                        else
                        {
                            pbCrownPlayerTwo.Visible = false;
                            pbCrownPlayerOne.Visible = false;
                            MessageBox.Show("Game Is Done" + Environment.NewLine + "Draw!",
                               "End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GoToStartMenue();
                            return true;
                        }

                    }


                    return true;
                }
            }

            return false;

        }

        bool CheckWinner()
        {
            if (CheckThreePictureBoxes(pb1, pb2, pb3)) 
                return true;

            if (CheckThreePictureBoxes(pb4, pb5, pb6))
                return true;

            if (CheckThreePictureBoxes(pb7, pb8, pb9))
                return true;

            if (CheckThreePictureBoxes(pb1, pb4, pb7))
                return true;

            if (CheckThreePictureBoxes(pb2, pb5, pb8))
                return true;

            if (CheckThreePictureBoxes(pb3, pb6, pb9))
                return true;

            if (CheckThreePictureBoxes(pb1, pb5, pb9))
                return true;

            if (CheckThreePictureBoxes(pb3, pb5, pb7))
                return true;

            else
                return false;

        }

        void StartGame(PictureBox pb)
        {
            if (pb.Tag.ToString() == "?")
            {


                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btnLetterPlayerOne.Enabled = false;
                        btnLetterPlayerTwo.Enabled = true;
                        PlayerTurn = enPlayer.Player2;
                        GameStatue.NumberOfClickes++;



                        if (!IsNextRound)
                        {
                            if (rbO.Checked)
                            {
                                pb.Image = Resources.O;
                                pb.Tag = "O";
                            }
                            else
                            {
                                pb.Image = Resources.X;
                                pb.Tag = "X";
                            }

                        }

                        else
                        {
                            if (!rbO.Checked)
                            {
                                pb.Image = Resources.O;
                                pb.Tag = "O";
                            }
                            else
                            {
                                pb.Image = Resources.X;
                                pb.Tag = "X";
                            }
                            IsNextRound = false;
                        }

    

                        if (CheckWinner())
                        {
                            return;
                        }

                        break;

                    case enPlayer.Player2:
                        btnLetterPlayerTwo.Enabled = false;
                        btnLetterPlayerOne.Enabled = true;
                        PlayerTurn = enPlayer.Player1;
                        GameStatue.NumberOfClickes++;

                        if (IsNextRound)
                        {
                            if (!rbO.Checked)
                            {
                                pb.Image = Resources.O;
                                pb.Tag = "O";
                            }
                            else
                            {
                                pb.Image = Resources.X;
                                pb.Tag = "X";
                            }

                            IsNextRound = false;
                        }

                        else
                        {
                            if (!rbO.Checked)
                            {
                                pb.Image = Resources.O;
                                pb.Tag = "O";
                            }
                            else
                            {
                                pb.Image = Resources.X;
                                pb.Tag = "X";
                            }
                        }

                        if (CheckWinner())
                        {
                            return;
                        }

                        break;



                }

                if (GameStatue.NumberOfClickes == 9)
                {
                    MessageBox.Show("Draw !", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnLetterPlayerOne.Enabled = false;
                    //btnLetterPlayerTwo.Enabled = false;
                    lblNameOfPlayerTwo.ForeColor = Color.White;
                    lblNameOfPlayerOne.ForeColor = Color.White;
                    GameStatue.NumberOfDraw++;
                    lblNumberOfDraw.Text = (Convert.ToByte(lblNumberOfDraw.Text) + 1).ToString();

                    if (Convert.ToByte(lblNumberOfCurrentRound.Text) + 1 < Convert.ToByte(combRounds.Text))
                    {
                        NextRound();
                    }

                    else
                    {
                        if (GameStatue.NumberOfWinningToPlayer1 > GameStatue.NumberOfWinningToPlayer2)
                        {
                            pbCrownPlayerOne.Visible = true;
                            pbCrownPlayerTwo.Visible = false;
                            MessageBox.Show("Game Is Done" + Environment.NewLine + $"The Winner is ( {lblNameOfPlayerOne.Text} )",
                                "End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GoToStartMenue();
                            return;
                        }

                        else if (GameStatue.NumberOfWinningToPlayer1 < GameStatue.NumberOfWinningToPlayer2)
                        {
                            pbCrownPlayerTwo.Visible = true;
                            pbCrownPlayerOne.Visible = false;
                            MessageBox.Show("Game Is Done" + Environment.NewLine + $"The Winner is ( {lblNameOfPlayerTwo.Text} )",
                               "End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GoToStartMenue();
                            return;
                        }

                        else
                        {
                            pbCrownPlayerOne.Visible = false;
                            pbCrownPlayerTwo.Visible = false;
                            MessageBox.Show("Game Is Done" + Environment.NewLine + "Draw!",
                               "End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GoToStartMenue();
                            return;
                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("Wrong Choice!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void DeterminPlayersAndLetters()
        {
            btnLetterPlayerOne.Enabled = true;
            btnLetterPlayerTwo.Enabled = false;

            lblNumberOfRounds.Text = combRounds.Text;

            if (rbTwoPlayer.Checked)
            {
                lblNameOfPlayerOne.Text = txtNameOne.Text;
                lblNameOfPlayerTwo.Text = txtNameTwo.Text;

            }
            else
            {
                lblNameOfPlayerOne.Text = txtNameOne.Text;
                lblNameOfPlayerTwo.Text = "Computer";
            }

            if (rbO.Checked)
            {
                btnLetterPlayerOne.Image = Resources.O;
                btnLetterPlayerTwo.Image = Resources.X;
            }
            else
            {
                btnLetterPlayerOne.Image = Resources.X;
                btnLetterPlayerTwo.Image = Resources.O;
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            EndableOptionsScreen();

            DisableStartMenue();

            if (Convert.ToBoolean(rbOnePlayer.Tag)) 
            {
                rbOnePlayer.Checked = false;
                rbTwoPlayer.Checked = false;
                rbOnePlayer.Tag = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!CheckAllOptions())
            {
                MessageBox.Show("Options are incompleted !" + Environment.NewLine +
                    "Check all options", "Inputs Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

            else
            {
                EnableGameScreen();
                DisableStartMenue();
                DeterminPlayersAndLetters();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DisableOptionsScreen();
            EnableStartMenue();

            
        }

        private void rbOnePlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOnePlayer.Checked)
            {
                combLevel.Visible = true;
                combLevel.Tag = true;
            }
            else
            {
                combLevel.Visible = false;
                combLevel.Tag = false;
            }


        }

        private void rbTwoPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTwoPlayer.Checked)
            {
                combLevel.Visible = false;
                lblNameTwo.Visible = true;
                txtNameTwo.Visible = true;
                txtNameTwo.Tag = true;
            }

            else
            {
                lblNameTwo.Visible = false;
                txtNameTwo.Visible = false;
                txtNameTwo.Tag = false;
            }
        }


        private void pb_Click(object sender, EventArgs e)
        {
            StartGame(((PictureBox)sender));
        }
    }
}
