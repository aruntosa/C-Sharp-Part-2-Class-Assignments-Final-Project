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
    class Election
    {
        //data members
        const int NUMCANDIDATES = 5;
        int[] votes = new int[NUMCANDIDATES];
        string[] candidates = new string[NUMCANDIDATES];

        //constructor with arguments
        public Election(string name, int votes, int count)
        { 
            candidates[count] = name;
            this.votes[count] = votes;
        }

        //setter
        public int NumberOfCandidates
        {
            get { return NUMCANDIDATES; }
        }

        //setting name in an array
        public void SetCandidateName(string name, int count)
        {
            candidates[count] = name;
        }

        //to return the name of the candidate
        public string GetCandidateName(int count)
        {
            string value = "";
            if (count < NumberOfCandidates)
            { value = candidates[count]; }
            return value;
        }

        //setting the number of votes in the array
        public void SetVotes(int votes, int count)
        {
            this.votes[count] = votes;
        }

        //to return the number of votes
        public int GetCandidateVotes(int count)
        {
            int value = 0;
            if(count < NumberOfCandidates)
                value = votes[count];
            return value;
        }

        //to return total number of votes
        public int TotalVotes()
        {
            int count = 0;
            int totalvotes = 0;
            while (count < 5)
            {
                totalvotes = votes[count] + totalvotes;
                count += 1;
            }
            return totalvotes;
        }

        //returns the winner
        public string FindWinner()
        {
            int winner = 0;
            int lead = 0;
            for (int i = 0; i < NumberOfCandidates; i++)
            {
                if (this.votes[i] > lead)
                { 
                    lead = this.votes[i];
                    winner = i;
                }
            }
            return candidates[winner].ToString();
        }
    }
}
