using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace app.obj
{
    public class Player
    {
        public static char RequestPlayerGuess(Game g)
        {
            
            string userInput = Console.ReadLine();

            while (!CheckPlayerGuess(userInput, g))
            {
                g.DisplayGame();
                userInput = Console.ReadLine();
            }

            char userInputChar = Convert.ToChar(userInput);
            
            return userInputChar;
        }

        public static bool CheckPlayerGuess(string playerGuessText, Game g)
        {
            char playerGuess;

            if (char.TryParse(playerGuessText, out playerGuess) == true && Char.IsLetter(playerGuess) == true && !g.AlreadyGuessed(playerGuess))
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