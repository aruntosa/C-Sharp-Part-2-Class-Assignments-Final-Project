using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*********************************
// Programmer : Arun
// Course : ITDEV115

//*********************************

namespace StudentHours
{
    class StudentUI
    {
        string[] days = new String[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Student newStudent;

        public void Mainmethod()
        {
            int id;
            string name;

            Console.Write("Enter ID : ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            newStudent = new Student(id, name);
            
            Student newStudent1 = new Student(id);
            newStudent1.Name = name;

            FillHours();
            DisplayData();
            DisplayAverage();
            Console.ReadLine();
        }

        public void FillHours()
        {
            for (int i=0; i<days.Length; i++)   
            {
                double hours = 0;
                bool result = false;

                Console.Write("Enter study hours for " + days[i] + " :  ");
                while(result == false)
                {
                    result = double.TryParse(Console.ReadLine(), out hours);
                    if (result == false)
                        Console.WriteLine("Please enter a number");
                }
                newStudent.EnterHours(i, hours);
            }
        }

        public void DisplayData()
        {

            Console.WriteLine("*****************************");
            Console.WriteLine("");
            Console.WriteLine("Student ID   : " + newStudent.Id);
            Console.WriteLine("Student Name : " + newStudent.Name);

        }

        public void DisplayAverage()
        {
            newStudent.GetAverageHours();
            double totalhrs;
            double avghrs;
            totalhrs = newStudent.GetNumberHours();
            avghrs = newStudent.GetAverageHours();
            Console.WriteLine("");
            Console.WriteLine("Total Hours studied           : " + totalhrs);
            Console.WriteLine("Average hours studied per day : " + avghrs);
        
        }
    }
}
