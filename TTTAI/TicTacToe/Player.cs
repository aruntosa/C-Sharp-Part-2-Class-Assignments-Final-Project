using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//****Programmer - Arun****
//****Course - ITDEV115****

namespace TTTAI
{
    abstract class Player
    {
        const int NUM_PIECES = 2;
        char[] PIECES = { 'O', 'X' };
        static int current = 0; 
        protected char m_Piece;

        public Player()//constructor
        {
            m_Piece = PIECES[current];
            current = (current + 1) % NUM_PIECES; 
        }

        public char Piece //returns a player's piece
        {
            get { return m_Piece; }
        }

        public abstract void MakeMove(ref Board theBoard);//makes a move on the board
        
    }
}
