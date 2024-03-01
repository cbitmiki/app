using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Metadata.Ecma335;


namespace app.obj
{
    public class Word
    {
        public static List<char> wordBank = new List<char>();
        public static string GetAWord()
        {
            string[] allLines = File.ReadAllLines(@"Words.txt");
            Random r = new Random();
            return (allLines[r.Next(0,allLines.Length)]);
        }

        public static int GetWordStringLength(string chosenWord)
       {

        int chosenWordLength = 0;

        foreach (char letter in chosenWord)
        {
           chosenWordLength++; 
        }
        return chosenWordLength;
       }

       public static Char[] InitializeGameBoard(int wordLength)
       {

        List<char> coveredBoard = new List<char>();
        for (int i = 0; i < wordLength; i++)
        {
            coveredBoard.Add('_');
        }
        
// This part below seems like it might need to be in a different function

        foreach (char character in coveredBoard)
        {
            Console.Write(character + " "); 
        }

       Char[] coveredBoardArray = coveredBoard.ToArray(); 

       return coveredBoardArray;   

       } 

        public void AddToWordBank(char playerGuess)
        {
            wordBank.Add(playerGuess);
        }
    }
}