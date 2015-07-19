using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//****Programmer - Arun****
//****Course - ITDEV115****

namespace FarmerGame
{
    class FarmerGame
    {        
        public enum Direction { North, South };

        private Direction farmer;
        private List<string> northBank;
        private List<string> southBank;

        public FarmerGame()
        {
            //initial Start of Game
            northBank = new List<string>();
            southBank = new List<string>();
            farmer = Direction.North;
            northBank.Add("chicken");
            northBank.Add("fox");
            northBank.Add("grain");
        }
        
        //getters
        public Direction Farmer
        {
            get { return farmer; }
        }          
        
        //methods
        public void Move(string choice)
        {
            if (farmer == Direction.North) //going south
            {
                farmer = Direction.South;
                if (!this.northBank.Contains(choice))
                    return;
                northBank.Remove(choice);
                southBank.Add(choice);              
            }
            else //going North.
            {
                if (farmer != Direction.South)
                    return;
                farmer = Direction.North;
                if (southBank.Contains(choice))
                {
                    southBank.Remove(choice);
                    northBank.Add(choice);
                }
            }
        }

        public string NorthBank()
        { 
            string northBankString1 = "";
            foreach (string northBankString2 in this.northBank)
                northBankString1 = northBankString1 + " " + northBankString2;
            return northBankString1;
        }

        public string SouthBank()
        {
            string southBankString1 = "";
            foreach (string southBankString2 in this.southBank)
                southBankString1 = southBankString1 + " " + southBankString2;
            return southBankString1;
        }
        
        public bool AnimalAteFood()
        {
            bool value = false;
            if (farmer == Direction.South)
            {
                if (northBank.Contains("chicken") && northBank.Contains("grain"))
                    value = true;
                else if (northBank.Contains("chicken") && northBank.Contains("fox"))
                    value = true;
            }
            if (farmer == Direction.North)
            {
                if (southBank.Contains("chicken") && southBank.Contains("grain"))
                    value = true;
                else if (southBank.Contains("chicken") && southBank.Contains("fox"))
                    value = true;
            }
            return value;
        }

        public bool DetermineWin()
        { 
            bool value = false;
            if (southBank.Contains("chicken") && southBank.Contains("grain") && southBank.Contains("fox"))
            {
                value = true;
            }
            return value;
        }

        public bool GameOver()
        {
            return AnimalAteFood() || DetermineWin();
        }
    }
}
