using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Programmer - Arun
Instructor - Judith Ligocki
Assignment #7 - Trivia Game */

namespace TriviaGameGUI
{
    public partial class FrmMain : Form
    {
        Info myinfo = new Info();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            TriviaUI form = new TriviaUI();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            TriviaUI form = new TriviaUI();
            form.Close(); 
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.lblWelcome.Text = myinfo.DisplayInfo().ToString();
        }
    }
}
