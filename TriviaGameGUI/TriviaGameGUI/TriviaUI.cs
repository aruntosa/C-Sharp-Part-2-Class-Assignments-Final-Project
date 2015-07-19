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
    public partial class TriviaUI : Form
    {
        private QuestionBank Questions = new QuestionBank();
        private int curQuestion = 0;
        private int correct;
        private int incorrect;

        public TriviaUI()
        {
            InitializeComponent();
            this.Questions = new TriviaGameGUI.QuestionBank();
        }

        public void Play()
        {

            string[] strArray1 = new string[4];
            char[] chArray = new char[1]
            {
                Convert.ToChar(",")
            };//display the questions.txt to a string array

            this.Questions.ReadQuestionFile("Questions.txt");
            if (this.curQuestion < this.Questions.GetNumberofQuestions)
            {
                this.lblCurrent.Text = this.Questions.GETQuestion(this.curQuestion);
                // lblCurQuestion.Text = this.Questions.GETQuestion(++index);
                string[] strArray2 = this.Questions.GETAnswer(this.curQuestion).Split(chArray);
                this.lblOptionA.Text = "A.  " + strArray2[0];
                this.lblOptionB.Text = "B. " + strArray2[1];
                this.lblOptionC.Text = "C. " + strArray2[2];
                this.lblOptionD.Text = "D. " + strArray2[3];
            }
        }

        public string PromptForGuess()
        {
            string str = this.txtAnswer.Text;
            if (str != null)
                str = str.Substring(0).ToUpper();
            return str;
        }

        private void TriviaUI_Load(object sender, EventArgs e)
        {
            string[] strArray1 = new string[4];
            char[] chArray = new char[1]
            {
                Convert.ToChar(",")
            };//display the questions.txt to a string array

            int index = 0;

            this.Questions.ReadQuestionFile("Questions.txt");
            for (; index < this.Questions.GetNumberofQuestions; index++)
            {
                lblCurrent.Text = this.Questions.GETQuestion(this.curQuestion);
                string[] strArray2 = this.Questions.GETAnswer(this.curQuestion).Split(chArray);
                this.lblOptionA.Text = "A.  " + strArray2[0];
                this.lblOptionB.Text = "B. " + strArray2[1];
                this.lblOptionC.Text = "C. " + strArray2[2];
                this.lblOptionD.Text = "D. " + strArray2[3];
            }

            this.txtAnswer.Focus();
        }

        public void VerifyAnswers()
        {
            string str = this.PromptForGuess();
            if (str == "A" || str == "B" || str == "C" || str == "D")
            {
                if (str == this.Questions.GETCorrectAnswer(curQuestion))
                {
                    ++this.correct;
                    txtCorrect.Text = correct.ToString();
                    int num = (int)MessageBox.Show("Correct!");
                }
                else
                {
                    ++this.incorrect;
                    txtIncorrect.Text = incorrect.ToString();
                    int num = (int)MessageBox.Show("Incorrect..." + this.Questions.GETExplanation(curQuestion));
                }

                this.curQuestion = this.curQuestion + 1;
            }
            else
            {
                int num1 = (int)MessageBox.Show("Please enter a valid guess.");
            }

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.curQuestion = 0;
            this.correct = 0;
            this.incorrect = 0;
            txtCorrect.Text = "";
            txtIncorrect.Text = "";
            string[] strArray1 = new string[4];
            char[] chArray = new char[1]
            {
                Convert.ToChar(",")
            };

            this.lblCurrent.Text = this.Questions.GETQuestion(this.curQuestion);

            string[] strArray2 = this.Questions.GETAnswer(this.curQuestion).Split(chArray);
            this.lblOptionA.Text = "A.)  " + strArray2[0];
            this.lblOptionB.Text = "B.) " + strArray2[1];
            this.lblOptionC.Text = "C.) " + strArray2[2];
            this.lblOptionD.Text = "D.) " + strArray2[3];

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.VerifyAnswers();
            this.Play();
            this.txtAnswer.Text = "";
            this.txtAnswer.Focus();

            if (this.curQuestion >= 5)
            {
                int GameOver = (int)MessageBox.Show("Thank you for playing. Please play again or Quit.");
            }
        }


    }
}
