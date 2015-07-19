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
    class Program
    {
        static void Main(string[] args)
        {
            Info myInfo = new Info();
            myInfo.DisplayInfo("Election Result");

            ElectionUI newEUI = new ElectionUI();
            newEUI.MainMethod();
        }
    }
}
