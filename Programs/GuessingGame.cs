using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hi
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            string secretWord = "balloon";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses)
            {
                if(guessCount < guessLimit)
                {
                    Console.WriteLine("Guess a word: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } else
                {
                    outOfGuesses = true;
                }

            }
            if(outOfGuesses)
            {
                Console.WriteLine("You lose!");
            } else
            Console.WriteLine("You win!");

            Console.ReadLine();
        }
    }
}