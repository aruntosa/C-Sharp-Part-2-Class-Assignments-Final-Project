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
    class Student
    {
        //data members
        int id;
        string name;
        double[] hours = new double[7];

        //getters and setters
        public int Id
        { get { return id; } }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //methods and constructors
        //Constructors with single and double arguments    

        public void EnterHours(int count, double value)
        {
            hours[count] = value;
        }

        public double GetNumberHours()
        {
            double total = 0;
            for (int i = 0; i < hours.Length; i++)
            {
                total = total + hours[i];
            }
            return total;
        }

        public double GetAverageHours()
        {
            double avg;
            double total = GetNumberHours();
            avg = total / hours.Length;
            return Math.Round(avg, 2);
        }

        public Student(int theId)
        {
            id = theId;
            name = "";

            for (int i = 0; i < hours.Length; i++)
            {
                hours[i] = 0;
            }
        }

        public Student(int theId, string theName)
        {
            id = theId;
            name = theName;

            for (int i = 0; i < hours.Length; i++)
            {
                hours[i] = 0;
            }
        }
    }
}
