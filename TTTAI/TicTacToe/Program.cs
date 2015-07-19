using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//****Programmer - Arun****
//****Course - ITDEV115****

namespace TTTAI
{
    class Program
    {
        static void Main(string[] args)
        {
            Info myInfo = new Info();
            myInfo.DisplayInfo("Tic Tac Toe Game with Inheritance and AI");

            TicTacToeUI newTTT = new TicTacToeUI();
            newTTT.Play();
            Console.ReadKey();
        }
    }
}
