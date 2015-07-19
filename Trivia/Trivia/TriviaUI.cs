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
    class TriviaUI
    {
        private QuestionBank Questions = new QuestionBank();

        public void Play()
        {
            int numCorrect = 0;
            int numWrong = 0;
            char[] chArray = new char[1]
            {
                Convert.ToChar(",")
            };
            int index = 0;
            DisplayWelcome();

            if (!Questions.ReadQuestionFile("Questions.txt"))
            {
                Console.WriteLine("Exception caught and handled");
            }

            for (index = 0; index < this.Questions.GetNumberofQuestions; index++)
            {
                Console.WriteLine(this.Questions.GETQuestion(index));
                string[] strQuestions = this.Questions.GETAnswer(index).Split(chArray);
                Console.WriteLine();
                Console.WriteLine("A.)  " + strQuestions[0]);
                Console.WriteLine("B.) " + strQuestions[1]);
                Console.WriteLine("C.) " + strQuestions[2]);
                Console.WriteLine("D.) " + strQuestions[3]);
                Console.WriteLine();
                if (this.PromptforGuess() == this.Questions.GETCorrectAnswer(index))
                {
                    numCorrect++;
                    Console.WriteLine("Good Job! Keep it up!\n");
                }
                else
                {
                    numWrong++;
                    Console.WriteLine("Wrong. " + this.Questions.GETExplanation(index) + "\n");
                }
            }
            Console.WriteLine("Total Questions: " + (numCorrect + numWrong));
            Console.WriteLine("Correct Answers: " + numCorrect);
            Console.WriteLine("Incorrect Answers: " + numWrong);
            Console.WriteLine();
            if (numWrong == 0)
                Console.WriteLine("EXCELLENT, KEEP UP THE GOOD WORK");
            else
                Console.WriteLine("BETTER LUCK NEXT TIME");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("\nWelcome to C Exam!\nGood Luck\n");
            Console.WriteLine("If you are ready for the exam, press ENTER to start");
            Console.ReadLine();
        }

        public string PromptforGuess()
        {
            Console.Write("Select A, B, C, or D : ");
            string choice = Console.ReadLine();
            if (choice != null)
                choice = choice.Substring(0).ToUpper();
            return choice;
        }

        public void PlayAgain()
        {
            do
            {
                this.Play();
                Console.WriteLine("\nDo you want to play again? Enter Y or N: ");
            }
            while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("\nPlease press enter to quit...");
        }
    }
}
