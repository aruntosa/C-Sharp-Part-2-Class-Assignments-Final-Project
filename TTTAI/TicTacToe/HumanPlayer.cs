using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//****Programmer - Arun****
//****Course - ITDEV115****

namespace TTTAI
{
    class HumanPlayer : Player
    {
        public override void MakeMove(ref Board theBoard)
        {
            int result;
            do
            {
                Console.WriteLine("Player " + (object)this.m_Piece + " make your move.");
                int.TryParse(Console.ReadLine(), out result);

                if (!theBoard.IsLegalMove(result))
                    Console.WriteLine("Player " + (object)this.m_Piece + "illegal move! Try again.");
            }

            while (!theBoard.IsLegalMove(result));

            theBoard.ReceiveMove(this.m_Piece, result);
        }
    }
}
