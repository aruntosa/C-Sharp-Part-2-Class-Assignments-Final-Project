using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*********************************
// Programmer : Arun
// Course : ITDEV115
//
//*********************************

namespace ElectionResult
{
    class ElectionUI
    {
        Election newElection;

        public void MainMethod()
        {
            string name = "";
            int votes = 0, i = 0;
            newElection = new Election(name, votes, i);
            Console.WriteLine("Please enter the candidate name and the number of votes");
            Console.WriteLine("");
            Console.WriteLine("**************************************");
            Console.WriteLine("");
            for (i = 0; i < newElection.NumberOfCandidates; i++)
            {
                Console.WriteLine("");
                name = PromptForString("Enter Candidate Name : ");
                votes = PromptForInt("Enter number of votes for " + name + " : ");
                newElection.SetCandidateName(name, i);
                newElection.SetVotes(votes, i);
            }
            Console.WriteLine("");
            Console.WriteLine("Election Result");
            Console.WriteLine("");
            DisplayResults();
            Console.ReadLine();
        }

        string PromptForString(string inValue)
        {
            Console.Write(inValue);
            return (Console.ReadLine());
        }

        int PromptForInt(string inValue)
        {
            Console.Write(inValue);
            return int.Parse(Console.ReadLine());
        }

        void DisplayResults()
        {
            Console.WriteLine("");
            Console.WriteLine("Total number of votes :" + newElection.TotalVotes());
            Console.WriteLine("");
            Console.WriteLine("Candidate Name" + "\t" + "Total Votes" + "\t" + "Percentage");
            Console.WriteLine("**************" + "\t" + "***********" + "\t" + "**********");
            Console.WriteLine("");
            for (int i = 0; i < newElection.NumberOfCandidates; i++)
            {
                double percent;
                Console.WriteLine("");
                percent = Convert.ToDouble(newElection.GetCandidateVotes(i)) / Convert.ToDouble(newElection.TotalVotes());
                double percentage = Math.Round((percent * 100), 2);
                Console.Write("\n" + newElection.GetCandidateName(i) + "\t" + "\t" + newElection.GetCandidateVotes(i) +"\t" + "\t" + percentage);
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.Write("The Winner is ***********  " + newElection.FindWinner() + "  ************");
        }
    }
}
