using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//****Programmer - Arun****
//****Course - ITDEV115****

namespace FarmerGame
{
    class FarmerGameUI
    {
        //object variable.
        private FarmerGame thegame;

        public void DisplayGameState()
        {
            if (thegame.Farmer == FarmerGame.Direction.North)
            {                
                Console.WriteLine("Farmer" + thegame.NorthBank());                             
                DisplayNorthBank();
                DisplayRiver();
                DisplaySouthBank();
                Console.WriteLine(thegame.SouthBank());
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine(thegame.NorthBank());                             
                DisplayNorthBank();
                DisplayRiver();                
                Console.ForegroundColor = ConsoleColor.White;                
                DisplaySouthBank();
                Console.WriteLine("Farmer" + thegame.SouthBank());
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("The Farmer Game");
            Console.WriteLine();
            Console.WriteLine("Help the farmer to bring his Chicken, Fox and Grain from");
            Console.WriteLine("North bank to South bank of the river. The condition is that");
            Console.WriteLine("the farmer cannot carry more than one item in each trip");
            Console.WriteLine("");
            Console.WriteLine("You will lose the game if, ");
            Console.WriteLine("The chicken and grain were together, or if");
            Console.WriteLine("The chicken and fox were together");
            Console.WriteLine("");
            Console.WriteLine("To win, you must successfully move them over to the South bank one at a time");
        }

        public void DisplayRiver()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");            
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        private void DisplayNorthBank()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("##################################");
        }
        
        private void DisplaySouthBank()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("##################################");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Play() //controlling Loop
        {            
            thegame = new FarmerGame(); //new game.
            DisplayWelcome();

            Console.WriteLine("Press any key to continue...");
            Console.WriteLine();
            Console.ReadKey();            

            while (!thegame.GameOver())
            {
                DisplayGameState();
                ProcessChoice(PromptForMove());

                if (thegame.AnimalAteFood())
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("You lost the game, since animal ate the food");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }

                if (thegame.DetermineWin())
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won the game !!! ");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
        }

        public void PlayAgain()
        {
            string inValue = "Y";

            do
            {
                Play();
                Console.Write("Try again : Enter Y or N");
                inValue = Console.ReadLine();
                if (inValue.Length > 0)
                    inValue = inValue.Substring(0, 1);
                inValue = inValue.ToUpper();
            }
            while (inValue == "Y");
        }

        public string PromptForMove()
        {
            Console.WriteLine();
            Console.WriteLine("What do you want to move ? ");
            Console.WriteLine();
            return Console.ReadLine().ToLower();
        }

        public void ProcessChoice(string choice)
        {
            thegame.Move(choice);
        }
    }
}
