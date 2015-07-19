using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programmer : Arun Kumar

namespace JumbleGame
{
    class Info
    {
            public void DisplayInfo(string assignmentName)
            {
                Console.WriteLine("                 My Info              ");
                Console.WriteLine("");
                Console.WriteLine("**************************************");
                Console.WriteLine("Name          : Arun");
                Console.WriteLine("Instructor    : Ligocki");
                Console.WriteLine("Course        : Intermediate OOP");
                Console.WriteLine("Date          : {0}", System.DateTime.Today.ToShortDateString());
                Console.WriteLine("Assignment    : " + assignmentName);
                Console.WriteLine("**************************************");
                Console.WriteLine();
            }        
    }
}
