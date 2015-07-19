using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programmer : Arun Kumar

namespace JumbleGame
{
    class Jumble
    {
        //data members
        String[] aryWord = new String[] { "TOYOTA", "HONDA", "NISSAN", "FORD", "HYUNDAI", "MITSUBISHI", "FIAT"};
        char[] displayWord;
        String word;

        //getters and setters
        public string HiddenWord
        {
            get { return word; }
        }
        
        //methods and constructors
        public Jumble()
        {
            GenerateRandomNumber();
            ScrambleWord();
        }

        public void GenerateRandomNumber()
        {
            int rand;
            Random newRand = new Random();
            rand = newRand.Next(0, aryWord.Length);
            word = aryWord[rand];
        }

        public void ScrambleWord()
        {
            int rand;
            Random newRand = new Random();
            char temp;
            displayWord = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                do rand = newRand.Next(word.Length);
                while (displayWord[rand] != 0);
                temp = word[i];
                displayWord[rand] = temp;
            }
        }
       
        public string DisplayScramble()
        {
            string sample = "";
            for (int i = 0; i < displayWord.Length; i++)
            { 
                sample = sample + displayWord[i];
            }
            return sample;
        }

        public void PlayAgain()
        {
            string playAgain = "Y";

            do
            {
                UIJumble newUI = new UIJumble();
                newUI.DisplayWelcome();
                newUI.Play();

                Console.WriteLine("Do you like to Play again ? :");
                playAgain = Console.ReadLine();

                if (playAgain.Length > 0)
                    playAgain = playAgain.Substring(0, 1);
                playAgain = playAgain.ToUpper();
            }
            while (playAgain == "Y");
        }
    }
}
