using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//****Programmer - Arun****
//****Course - ITDEV115****

namespace TTTAI
{
    class Board
    {
        const char EMPTY = ' ';
        const int NUM_SQUARE = 9;
        char[] m_Square = new char[NUM_SQUARE];

        public Board() //constructor
        {
            Reset();
        }

        public int NumofSquares
        {
            get { return NUM_SQUARE; }
        }

        public char[] TheGrid 
        {
            get { return m_Square; }
        }

        public void Reset()
        {
            for (int i = 0; i < NUM_SQUARE; i++)
            {
                m_Square[i] = EMPTY;
            }
        }

        public bool IsFull() //to test if anymore moves can be made
        {
            bool full = true;
            int i = 0;

            while (full && i < NUM_SQUARE)
            {
                if (m_Square[i] == EMPTY)
                {
                    full = false;
                }
                i++;
            }
            return full;
        }

        public bool IsLegalMove(int move) //to test if the move is legal
        {
            bool result;

            if (move >= 0 && move < NUM_SQUARE && m_Square[move] == EMPTY)
                result = true;
            else
                result = false;
            return result;
        }

        public bool IsWinner(char piece) // to test if the player is winner, with the moves in a pattern
        {
            bool winner = false;
            //across 3
            if (m_Square[0] == piece && m_Square[1] == piece && m_Square[2] == piece)
                winner = true;
            if (m_Square[3] == piece && m_Square[4] == piece && m_Square[5] == piece)
                winner = true;
            if (m_Square[6] == piece && m_Square[7] == piece && m_Square[8] == piece)
                winner = true;
            //down 3
            if (m_Square[0] == piece && m_Square[3] == piece && m_Square[6] == piece)
                winner = true;
            if (m_Square[1] == piece && m_Square[4] == piece && m_Square[7] == piece)
                winner = true;
            if (m_Square[2] == piece && m_Square[5] == piece && m_Square[8] == piece)
                winner = true;
            //diagonal
            if ((m_Square[0] == piece && m_Square[4] == piece && m_Square[8] == piece) || (m_Square[2] == piece && m_Square[4] == piece && m_Square[6] == piece))
                winner = true;
            return winner;
        }

        public void ReceiveMove(char piece, int move) //moving the piece to the specified position
        {
            m_Square[move] = piece;
        }
    }
}
