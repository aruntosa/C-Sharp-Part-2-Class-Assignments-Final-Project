using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//****Programmer - Arun****
//****Course - ITDEV115****

namespace TTTAI
{
    class ComputerPlayer : Player
    {
        private char GetOpponentPiece()
        {
            return (int)this.m_Piece == 79 ? 'X' : 'O';
        }

        public override void MakeMove(ref Board theBoard)
        {
            int[] numArray = new int[9]
            { 4,0,2,6,8,1,3,5,7 };

            int move = 0;

            bool flag = false;

            while (!flag && move < theBoard.NumofSquares)
            {
                if (theBoard.IsLegalMove(move))
                {
                    theBoard.ReceiveMove(this.m_Piece, move);
                    flag = theBoard.IsWinner(this.m_Piece);
                    theBoard.ReceiveMove(' ', move);
                }

                if (!flag)
                    ++move;
            }

            if (!flag)
                move = 0;

            while (!flag && move < theBoard.NumofSquares)
            {
                if (theBoard.IsLegalMove(move))
                {
                    theBoard.ReceiveMove(this.GetOpponentPiece(), move);
                    flag = theBoard.IsWinner(this.GetOpponentPiece());
                    theBoard.ReceiveMove(' ', move);
                }

                if (!flag)
                    ++move;
            }

            for (int index = 0; !flag && index < theBoard.NumofSquares; ++index)
            {
                move = numArray[index];
                if (theBoard.IsLegalMove(move))
                    flag = true;
            }

            theBoard.ReceiveMove(this.m_Piece, move);
        }
    }
}
