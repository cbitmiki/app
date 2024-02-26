using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace app.obj
{
    public class HangmanGame
    {
       public static void StartGame()
       {
        Word.InitializeGameBoard(Word.GetWordStringLength(Word.GetAWord()));
        Player.PlayerGuess();        
       }
    }
}