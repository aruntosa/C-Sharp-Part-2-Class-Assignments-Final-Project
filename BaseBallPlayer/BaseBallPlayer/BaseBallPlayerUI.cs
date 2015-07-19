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
    class BaseBallPlayerUI
    {
        public void MainMethod()
        {
            BaseBallPlayer bbp = new BaseBallPlayer();
            BaseBallPlayer bbp1 = new BaseBallPlayer();

            //setting through setters
            bbp.BattingAverage = 0.334m;
            bbp.FirstName = "John";
            bbp.LastName = "Smith";
            bbp.Team = "NightHawks";
            bbp1.BattingAverage = 0.337m;
            bbp1.FirstName = "Jimmy";
            bbp1.LastName = "Adams";
            bbp1.Team = "StreetFighters";

            DisplayInfo(bbp, bbp1);
        }

        public void DisplayInfo(BaseBallPlayer bbp, BaseBallPlayer bbp1)
        {
            Console.WriteLine("The Names of the teams are,                " + bbp.Team + ",     " + bbp1.Team);     
            Console.WriteLine("The First Names of the players are,        " + bbp.FirstName + ",           " + bbp1.FirstName);
            Console.WriteLine("The Last Names of the players are,         " + bbp.LastName + ",          " + bbp1.LastName);
            Console.WriteLine("The Batting Averages of the players are,   " + bbp.BattingAverage + ",          " + bbp1.BattingAverage);
        }        
    }
}
