using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//****Programmer - Arun****
//****Course - ITDEV115****

namespace FarmerGameGUI
{
    public partial class frmMain : Form
    {
        FarmerGameLogic mygame = new FarmerGameLogic();

        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DisableAll();
            DisplaySouthBank();
            DisplayNorthBank();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {            Close();        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Help the farmer to bring his Chicken, Fox and Grain from \n" +
             "North bank to South bank of the river. The condition is that \n" +
             "the farmer cannot carry more than one item in each trip \n" +
             "Game will be lost and over if, \n" +
             "A - If the chicken and grain were together or \n" +
             "B - If the chicken and fox were together \n" +
             "C - You win the game if you successfully cross all three of them to South Bank");
        }

        private void pictureBoxFarmerNorth_Click(object sender, EventArgs e)
        {
            mygame.Move("farmer");
            DisableAll();
            DisplayNorthBank();
            DisplaySouthBank();
            if (mygame.AnimalAteFood() == true)
            {
                MessageBox.Show("Game Lost \n" + "Animal ate the Food");
                PlayAgain();
            }
        }

        private void pictureBoxFarmerSouth_Click(object sender, EventArgs e)
        {
            mygame.Move("farmer");
            DisableAll();
            DisplayNorthBank();
            DisplaySouthBank();
            if (mygame.AnimalAteFood() == true)
            {
                MessageBox.Show("Game Lost \n" + "Animal ate the Food");
                PlayAgain();
            }
        }

        private void pictureBoxChickenNorth_Click(object sender, EventArgs e)
        {
            mygame.Move("chicken");
            DisableAll();
            DisplayNorthBank();
            DisplaySouthBank();
            if (mygame.DetermineWin() == true)   
            {
                MessageBox.Show("Winner !!! \n" + "You won the game");
                PlayAgain();
            }
        }

        private void pictureBoxChickenSouth_Click(object sender, EventArgs e)
        {
            mygame.Move("chicken");
            DisableAll();
            DisplayNorthBank();
            DisplaySouthBank();
        }

        private void pictureBoxFoxNorth_Click(object sender, EventArgs e)
        {
            mygame.Move("fox");
            DisableAll();
            DisplayNorthBank();
            DisplaySouthBank();
            //mygame.AnimalAteFood();
            if (mygame.AnimalAteFood() == true)                
            {
                MessageBox.Show("Game Lost \n" + "Animal ate the Food");
                PlayAgain();
            }
        }

        private void pictureBoxGrainNorth_Click(object sender, EventArgs e)
        {
            mygame.Move("grain");
            DisableAll();
            DisplayNorthBank();
            DisplaySouthBank();
            if (mygame.AnimalAteFood() == true)
            {
                MessageBox.Show("Game Lost \n" + "Animal ate the Food");
                PlayAgain();
            }
        }

        public void PlayAgain()
        {
            if (mygame.GameOver() == true)
            {
                DialogResult response;

                response = MessageBox.Show("Do you want to play again?", "First Program", MessageBoxButtons.YesNo);
                if (response == DialogResult.No)
                {
                    MessageBox.Show("Bye Bye");
                    Close();
                }
                if (response == DialogResult.Yes)
                {
                    mygame = new FarmerGameLogic();
                    DisableAll();
                    DisplaySouthBank();
                    DisplayNorthBank();
                }
            }
        }

        void DisableAll()
        {
            pictureBoxFarmerNorth.Enabled = false;
            pictureBoxChickenNorth.Enabled = false;
            pictureBoxFoxNorth.Enabled = false;
            pictureBoxGrainNorth.Enabled = false;

            pictureBoxFarmerSouth.Enabled = false;
            pictureBoxChickenSouth.Enabled = false;
            pictureBoxFoxSouth.Enabled = false;
            pictureBoxGrainSouth.Enabled = false;

            pictureBoxFarmerNorth.Visible = false;
            pictureBoxChickenNorth.Visible = false;
            pictureBoxFoxNorth.Visible = false;
            pictureBoxGrainNorth.Visible = false;

            pictureBoxFarmerSouth.Visible = false;
            pictureBoxChickenSouth.Visible = false;
            pictureBoxFoxSouth.Visible = false;
            pictureBoxGrainSouth.Visible = false;
        }

        //display northbank
        void DisplayNorthBank()
        {
            List<string> northBank;
            northBank = mygame.NorthBank;

            if (this.mygame.Farmer == FarmerGameLogic.Direction.North)
            {
                pictureBoxFarmerNorth.Visible = true;
                pictureBoxFarmerNorth.Enabled = true;
                pictureBoxChickenNorth.Enabled = true;
                pictureBoxFoxNorth.Enabled = true;
                pictureBoxGrainNorth.Enabled = true;

            }
            if (northBank.Contains("chicken"))
            {
                pictureBoxChickenNorth.Visible = true;
            }
            if (northBank.Contains("fox"))
            {
                pictureBoxFoxNorth.Visible = true;
            }
            if (northBank.Contains("grain"))
            {
                pictureBoxGrainNorth.Visible = true;
            }
        }

        //Display SouthBank
        void DisplaySouthBank()
        {
            List<string> southBank;
            southBank = mygame.SouthBank;
            if (mygame.Farmer == FarmerGameLogic.Direction.South)
            {
                pictureBoxFarmerSouth.Visible = true;
                pictureBoxFarmerSouth.Enabled = true;
                pictureBoxChickenSouth.Enabled = true;
                pictureBoxFoxSouth.Enabled = true;
                pictureBoxGrainSouth.Enabled = true;
            }
            if (southBank.Contains("chicken"))
            {
                pictureBoxChickenSouth.Visible = true;
            }
            if (southBank.Contains("fox"))
            {
                pictureBoxFoxSouth.Visible = true;
            }
            if (southBank.Contains("grain"))
            {
                pictureBoxGrainSouth.Visible = true;
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
             mygame = new FarmerGameLogic();
             DisableAll();
             DisplaySouthBank();
             DisplayNorthBank();
        }
    }
}
