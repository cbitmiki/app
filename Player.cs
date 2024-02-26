using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.obj
{
    public class Player
    {
        public static int playerLives = 5;
        public static char PlayerGuess()
        {
            Console.Write("Guess: ");
            string playerGuessString = Console.ReadLine();

            while (playerGuessString.Length != 1)
            {
                Console.WriteLine("Please guess one letter:");
                playerGuessString = Console.ReadLine();
            }

            char playerGuess = Convert.ToChar(playerGuessString);



            while (Char.IsDigit(playerGuess) == true || playerGuess == null || Word.wordBank.Contains(playerGuess) == true) // still need a condition that prevents player from selecting the same word over and over again
            {
                Console.WriteLine("Not valid.");
                Console.Write("Please guess a letter: ");
                playerGuess = char.Parse(Console.ReadLine());
            }

            return playerGuess;
        }

        public static void CheckPlayerLives()
        {
            if (playerLives < 0)
            {
                Console.Clear();
                Console.WriteLine("My program recognizes that the game is over!");
            }
        }
    }
}