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
    class Program
    {
        static void Main(string[] args)
        {
            Info myInfo = new Info();
            myInfo.DisplayInfo("Trivia Game");

            TriviaUI theTrivia = new TriviaUI();
            theTrivia.PlayAgain();
            Console.ReadKey();
        }
    }
}
