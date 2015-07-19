using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Programmer - Arun
Instructor - Judith Ligocki
Assignment #6 - Trivia Game */

namespace Trivia
{
    class QuestionUnit
    {
        private string m_Question;
        private string m_Answers;
        private string m_CurrectAnswer;
        private string m_Explanation;

        public string Question
        {
            get
            {
                return this.m_Question;
            }
            set
            {
                this.m_Question = value;
            }
        }

        public string Answer
        {
            get
            {
                return this.m_Answers;
            }
            set
            {
                this.m_Answers = value;
            }
        }

        public string CorrectAnswer
        {
            get
            {
                return this.m_CurrectAnswer;
            }
            set
            {
                this.m_CurrectAnswer = value;
            }
        }

        public string Explanation
        {
            get
            {
                return this.m_Explanation;
            }
            set
            {
                this.m_Explanation = value;
            }
        }
    }
}
