using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.obj
{
    public class Player
    {
        public static char PlayerGuess()
        {
            Console.Write("Guess: ");
            char playerGuess = char.Parse(Console.ReadLine());

            while (Char.IsDigit(playerGuess) == true || playerGuess == null) // still need a condition that prevents player from selecting the same word over and over again
            {
                Console.WriteLine("Not valid.");
                Console.Write("Please guess a letter: ");
                playerGuess = char.Parse(Console.ReadLine());
            }

            return playerGuess;
        }
    }
}