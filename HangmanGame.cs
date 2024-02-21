using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace app.obj
{
    public class HangmanGame
    {
       public static Char[] PrintGameBoard(int wordLength)
       {

        List<char> innitialGuessWordState = new List<char>();
        for (int i = 0; i < wordLength; i++)
        {
            innitialGuessWordState.Add('_');
        }
        
// This part below seems like it might need to be in a different function

        foreach (char character in innitialGuessWordState)
        {
            Console.Write(character + " "); 
        }

       Char[] innitialGuessWordStateArray = innitialGuessWordState.ToArray(); 

       return innitialGuessWordStateArray;   

       }

       public static int GetGameStringLength(string chosenWord)
       {

        int chosenWordLength = 0;

        foreach (char letter in chosenWord)
        {
           chosenWordLength++; 
        }
        return chosenWordLength;
       } 
    }
}