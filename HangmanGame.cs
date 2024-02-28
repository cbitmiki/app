using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net.Cache;
using System.Threading.Tasks;

namespace app.obj
{
    public class HangmanGame
    {
       public static void StartGame()
       {
        Word.InitializeGameBoard(Word.GetWordStringLength(Word.GetAWord()));
        Player.CheckPlayerGuess(Player.RequestPlayerGuess());  

        if (Player.CheckPlayerGuess(Player.RequestPlayerGuess()) == true)
        {
            Word.CheckCharToWord(Word.GetAWord(),Player.RequestPlayerGuess())
        }     
       }
    }
}