using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***************************
//Arun Kumar
//***************************
namespace BaseBallPlayer
{
    class BaseBallPlayer
    {
        //data members
        decimal battingavg;
        string fname;
        string lname;
        string team;

        //getters and setters
        public decimal BattingAverage
        {
            get { return battingavg; }
            set { battingavg = value; }
        }

        public string FirstName
        {
            get { return fname; }
            set { fname = value; }
        }

        public string LastName
        {
            get { return lname; }
            set { lname = value; }
        }

        public string Team
        {
            get { return team; }
            set { team = value; }
        }

        //methods
        //constructors
        public BaseBallPlayer()
        {
            battingavg = 0.0m;
            fname = null;
            lname = null;
            team = "";
        }
        
    }
}
