using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//****Programmer - Arun****
//****Course - ITDEV115****
 

namespace TTTAI
{
    class TicTacToeUI
    {
        int current = 0;
        const int NUM_PLAYERS = 2;
        const int FIRST = 0;
        const int SECOND = 1;
        Board theBoard = new Board();
        Player[] thePlayers = new Player[NUM_PLAYERS]; //array of players
       
        private void DisplayGrid() //to display the board
        {
            int numofelements;
            numofelements = theBoard.NumofSquares;

            char[] thegrid = new char[numofelements];
            thegrid = theBoard.TheGrid;

            Console.WriteLine();
            Console.WriteLine(" 0 | 1 | 2 " + "      {0} | {1} | {2} ", thegrid[0], thegrid[1], thegrid[2]);
            Console.WriteLine(" ---------- " + "      ---------");
            Console.WriteLine(" 3 | 4 | 5 " + "      {0} | {1} | {2} ", thegrid[3], thegrid[4], thegrid[5]);
            Console.WriteLine(" ---------- " + "      ---------");
            Console.WriteLine(" 6 | 7 | 8 " + "      {0} | {1} | {2} ", thegrid[6], thegrid[7], thegrid[8]);
            Console.Write("\n");            
        }

        public void DisplayWelcome()
        {
            Console.Write("Welcome to the Tic Tac Toe Game!\n");
            Console.Write("\n");
            Console.Write("**************************************");
            Console.Write("\n");
        }

        public void Play()
        {
            do
            {
                SetPlayers();
                current = 0;
                theBoard = new Board();
                do
                {            
                    DisplayGrid();
                    thePlayers[current].MakeMove(ref this.theBoard);
                    NextPlayer();
                }
                while (IsPlaying());
                DisplayGrid();
                IsTie();
                AnnounceWinner();
                theBoard = new Board();
                current = 0;

            } while (PlayAgain());  
            
        }       

        public void AnnounceWinner()
        {      
            if (theBoard.IsWinner(thePlayers[0].Piece))
            {
                Console.WriteLine();
                Console.Write("Congrats, you won the game, Player O!");
            }
            else if (theBoard.IsWinner(thePlayers[1].Piece))
            {
                Console.WriteLine();
                Console.Write("Congrats, you won the game, Player X!");
            }
        }

        private bool IsPlaying() //to test if the game is still on
        {
            return (!theBoard.IsFull() && !theBoard.IsWinner(thePlayers[FIRST].Piece) && !theBoard.IsWinner(thePlayers[SECOND].Piece));
        }

        public void IsTie() //to test a game for tie
        {
            if (theBoard.IsFull() && !theBoard.IsWinner(thePlayers[0].Piece) && !theBoard.IsWinner(this.thePlayers[1].Piece))
                Console.Write("Nobody wins, it's a TIE!");
        }

        private void NextPlayer() //sets current player to the next player
        {            
            if (current == 0)
                current = 1;
            else
                current = 0;
        }
       
        public bool PlayAgain()
        {
            bool anothergame = true;
            string response = "";
            Console.WriteLine("\n");
            System.Console.Write("\nDo you want to play again? Enter Y or N: ");
            response = System.Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y")
                anothergame = true;
            else if (response == "N")
                anothergame = false;

            return anothergame;
        }

        public int PromptForMove(char Piece)
        {
            int move;
            Console.WriteLine("Make a Move Player {0} ", Piece);
            int.TryParse(Console.ReadLine(), out move);

            return move;
        }

        private void SetPlayers()
        {
            for (int index = 0; index < 2; ++index)
            {
                Console.WriteLine("Choose for each X and O, whether they want to be Human or Computer players.)";
                string str = Console.ReadLine();
                if (str.Length > 0)
                    str = str.Substring(0, 1).ToUpper();
                if (str == "C")
                {
                    ComputerPlayer computerPlayer = new ComputerPlayer();
                    this.thePlayers[index] = (Player)computerPlayer;
                }
                else
                {
                    HumanPlayer humanPlayer = new HumanPlayer();
                    this.thePlayers[index] = (Player)humanPlayer;
                }
            }
        }
    }
}
