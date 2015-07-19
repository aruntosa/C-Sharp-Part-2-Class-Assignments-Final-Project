using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programmer : Arun Kumar

namespace JumbleGame
{
    class UIJumble
    {
        public void DisplayWelcome()
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("*             Welcome to Jumble Game                  *");
            Console.WriteLine("*           Unscramble the Hidden Word                *");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("");
        }

        Jumble newJumble = new Jumble();
        
        public void Play()
        {
            string word;
            Console.WriteLine("CAR MAKERS");
            Console.WriteLine("");
            Console.WriteLine("Scrambled Word " + newJumble.DisplayScramble() );
            word = newJumble.HiddenWord;
            Console.WriteLine("");
            Console.WriteLine("The first letter of the word is " + word[0]);            
            Console.WriteLine("The two starting letters of the word is " + word.Substring(0, 2));
            Console.WriteLine("");
            CompareString();            
        }

        public string TakeAGuess()
        {
            Console.WriteLine("");
            Console.WriteLine("Try to Unscramble the word");
            return Console.ReadLine().ToUpper();
        }

        public void CompareString()
        {
            while (TakeAGuess() != newJumble.HiddenWord)
            {
                Console.WriteLine("Try Again !!");
            }
            Console.WriteLine("");
            Console.WriteLine("Congratulations, the word is {0}.", newJumble.HiddenWord);
        }
    }
}
