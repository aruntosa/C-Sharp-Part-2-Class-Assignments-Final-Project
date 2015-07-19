using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Programmer - Arun
Instructor - Judith Ligocki
Assignment #7 - Trivia Game */

namespace TriviaGameGUI
{
    class Info
    {
        public string DisplayInfo()
        {
            string str;
            str = "Welcome to TriviaGameGUI!\nWelcome to the C exam\n\nName:  Arun\nAssignment:  Trivia Game GUI\n" +
            "Instructor:  Judy Ligocki\nDate:  " + DateTime.Now.ToShortDateString();
            return str;
        }
    }
}
