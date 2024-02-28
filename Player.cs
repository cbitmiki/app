using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace app.obj
{
    public class Player
    {
        public static int playerLives = 5;
        public static string RequestPlayerGuess()
        {
            Console.Write("Guess: ");
            return Console.ReadLine();
        }

        public static bool CheckPlayerGuess(string playerGuessText)
        {
            char playerGuess;

            if (char.TryParse(playerGuessText, out playerGuess) == true && Char.IsLetter(playerGuess) == true && Word.wordBank.Contains(playerGuess) != true)
            {
                return true;
            }
            else
            { 
                return false;
            }
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