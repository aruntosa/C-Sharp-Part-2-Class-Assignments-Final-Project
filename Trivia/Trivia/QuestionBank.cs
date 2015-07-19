using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Programmer - Arun
Instructor - Judith Ligocki
Assignment #6 - Trivia Game */

namespace Trivia
{
    class QuestionBank
    {
        private const int NUM_QUESTIONS = 5;
        private const int NUM_ANSWERS = 4;
        private QuestionUnit[] m_Questions = new QuestionUnit[NUM_QUESTIONS];

        public int GetNumberofAnswers
        {
            get
            {
                return NUM_ANSWERS;
            }
        }

        public int GetNumberofQuestions
        {
            get
            {
                return NUM_QUESTIONS;
            }
        }

        public string GETQuestion(int index)
        {
            return m_Questions[index].Question;
        }

        public string GETAnswer(int index)
        {
            return m_Questions[index].Answer;
        }

        public string GETCorrectAnswer(int index)
        {
            return m_Questions[index].CorrectAnswer;
        }

        public string GETExplanation(int index)
        {
            return m_Questions[index].Explanation;
        }

        public bool ReadQuestionFile(string path)
        {
            bool fileFound = true;
            int index = 0;
            try
            {
                using (StreamReader streamReader = new StreamReader("Questions.txt"))
                {
                    string text;
                    while ((text = streamReader.ReadLine()) != null)
                    {
                        m_Questions[index] = new QuestionUnit();
                        m_Questions[index].Question = text;
                        m_Questions[index].Answer = streamReader.ReadLine();
                        m_Questions[index].CorrectAnswer = streamReader.ReadLine();
                        m_Questions[index].Explanation = streamReader.ReadLine();
                        index++;
                    }
                }
            }
            catch
            {
                fileFound = false;
            }
            return fileFound;
        }
    }
}
