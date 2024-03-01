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
        public static char RequestPlayerGuess()
        {
            
            Console.Write("Guess: ");
            string userInput = Console.ReadLine();

            while (!CheckPlayerGuess(userInput))
            {
                Console.Write("Guess: ");
                userInput = Console.ReadLine();
            }

            char userInputChar = Convert.ToChar(userInput);
            
            return userInputChar;
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

    }
}