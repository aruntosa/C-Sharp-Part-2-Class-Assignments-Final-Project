using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programmer : Arun Kumar

namespace JumbleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Info myInfo = new Info();
            myInfo.DisplayInfo("2: Jumble Game");
            
            Jumble newJumble = new Jumble();
            newJumble.PlayAgain();
        }
    }
}
