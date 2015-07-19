using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//****Programmer - Arun****
//****Course - ITDEV115****

namespace FarmerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Info myInfo = new Info();
            myInfo.DisplayInfo("2A: Practice Arrays");

            FarmerGameUI theUI = new FarmerGameUI();
            theUI.PlayAgain();
            //Console.ReadLine();
            
        }
    }
}
