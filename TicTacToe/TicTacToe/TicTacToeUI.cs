using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//****Programmer - Arun****
//****Course - ITDEV115****
 

namespace TicTacToe
{
    class TicTacToeUI
    {
        int current = 0;
        const int NUM_PLAYERS = 2;
        const int FIRST = 0;
        const int SECOND = 1;
        Board theBoard = new Board();
        Player[] thePlayers = new Player[NUM_PLAYERS]; //array of players
       // TicTacToeLogic newTTTLogic = new TicTacToeLogic();

        public void DisplayBoardGrid()
        {
            Console.WriteLine();
            //Console.WriteLine(" 0 | 1 | 2 ");
            //Console.WriteLine(" ---------- ");
            //Console.WriteLine(" 3 | 4 | 5 ");
            //Console.WriteLine(" ---------- ");
            //Console.WriteLine(" 6 | 7 | 8 ");
            //Console.Write("\n");
        }

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
            //Console.WriteLine(" {0} | {1} | {2} ", thegrid[0], thegrid[1], thegrid[2]);
            //Console.WriteLine(" ---------");
            //Console.WriteLine(" {0} | {1} | {2} ", thegrid[3], thegrid[4], thegrid[5]);
            //Console.WriteLine(" ---------");
            //Console.WriteLine(" {0} | {1} | {2} ", thegrid[6], thegrid[7], thegrid[8]);
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
            DisplayWelcome();            

            do {
            thePlayers[0] = new Player();
            //testing
            Console.WriteLine("\n");
            Console.WriteLine("Player O - " + thePlayers[0].Piece);

            thePlayers[1] = new Player();
            Console.WriteLine("Player X - " + thePlayers[1].Piece);
            //Console.WriteLine("\n");
            int move;
            
            while (IsPlaying() == true)   //play until board full
            {
                //DisplayBoardGrid();
                DisplayGrid();

                move = PromptForMove(thePlayers[current].Piece);
                while (theBoard.IsLegalMove(move) == false)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Not a valid move, try again...");
                    move = PromptForMove(thePlayers[current].Piece);
                }

                thePlayers[current].MakeMove(ref theBoard, move);
                NextPlayer();
            }
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
    }
}
