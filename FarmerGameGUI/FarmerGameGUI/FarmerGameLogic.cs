using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//****Programmer - Arun****
//****Course - ITDEV115****

namespace FarmerGameGUI
{
    class FarmerGameLogic
    {        
        public enum Direction { North, South };
        private Direction farmer;
        private List<string> northBank;
        private List<string> southBank;

        public FarmerGameLogic()
        {   //initial State of Game
            northBank = new List<string>();
            southBank = new List<string>();
            farmer = Direction.North;
            northBank.Insert(0, "farmer");
            northBank.Add("chicken");
            northBank.Add("fox");
            northBank.Add("grain");
        }
        
        //getters
        public Direction Farmer
        { get { return farmer; } }

        public List<string> NorthBank
        { get { return northBank; } }

        public List<string> SouthBank
        { get { return southBank; } }
        
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
