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
            string[] allLines = File.ReadAllLines("Words.txt");
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

        public int CheckCharToWord (string chosenWord, char playerGuess)
        {
           
            foreach (char letter in chosenWord)
            {
                int letterIndex = -1;
                letterIndex++;

                if (playerGuess == letter)
                {
                    return letterIndex; 
                }
            }
            
            return -1;
        }

        public void UpdateBoardState(char playerGuess, int letterIndex, char[] answer)
        {
            if (letterIndex >= 0)
            {
                answer[letterIndex] = playerGuess;
                AddToWordBank(playerGuess);
            }
            else
            {
                AddToWordBank(playerGuess);
                Player.playerLives--;
                Player.CheckPlayerLives();
            }
        }

        public void AddToWordBank(char playerGuess)
        {
            wordBank.Add(playerGuess);
        }

        public bool CheckWordComplete(Char[] answer, int chosenWordLength)
        {
            int letterCount = 0;

            foreach (char c in answer)
            {
                if (Char.IsLetter(c) == true)
                letterCount++;
            }

            if (letterCount == chosenWordLength)
            {
             Console.WriteLine("The code has recognized that you have won!");
             return true;
            }

            return false;
        }

    }
}