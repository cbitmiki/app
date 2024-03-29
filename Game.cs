using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net.Cache;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace app.obj
{
    public class Game
    {
        private string word;
        private char[] wordCovered;
        private int guessesRemaining = 5;
        private List<char> incorrectGuesses = new List<char>();
        private List<char> allGuesses = new List<char>();
        string result = "lost";

        public Game(){}
        
        public void RunGame()
        {
            InitializeGame();

            while (!IsOver())
            {
                DisplayGame();
                UpdateGame(Player.RequestPlayerGuess(this));
            }
            DisplayResult();
            DisplayWord();
        }

        public void InitializeGame()
        {
            Console.Clear();
            word = Word.GetWord();
            wordCovered = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                wordCovered[i] = '_';
            }
            
        }

        public void UpdateGame(char c)
        {
            int i = 0;
            bool isWrong = true;

            foreach (char ch in word)
            {
                if (c == ch)
                {
                    wordCovered[i] = c;
                    isWrong = false;
                }
                i++;
            }

            if (isWrong)
            {
                guessesRemaining--;
                incorrectGuesses.Add(c);
            }

        }

        public bool IsOver()
        {
            if (!wordCovered.Contains('_'))
            {
                result = "won";
            }

            return !wordCovered.Contains('_') || guessesRemaining == 0;
        }
       
       public void DisplayGame()
       {
            Console.Write($"{DisplayWord()} | {DisplayRemainingGuesses()} | {DisplayIncorrectGuesses()} | Guess: ");
       }

       public string DisplayWord()
       {
            StringBuilder sb = new StringBuilder();
            sb.Append("Word:");
            foreach (char c in wordCovered)
            {
                sb.Append(" ");
                sb.Append(c);
            }

            return sb.ToString();
       }

       public string DisplayRemainingGuesses()
       {
            StringBuilder sb = new StringBuilder();
            sb.Append("Remaining: ");
            sb.Append(guessesRemaining);
            return sb.ToString();
       }

       public string DisplayIncorrectGuesses()
       {
            StringBuilder sb = new StringBuilder();
            sb.Append("Incorrect: ");
            foreach (char c in incorrectGuesses)
            {
                sb.Append(c);
            }
            return sb.ToString();
       }

       public bool AlreadyGuessed(char c)
       {
            return allGuesses.Contains(c);
       }

       public void DisplayResult()
       {
            Console.WriteLine($"You {result}.The word was {word}.");
       }
    }
}