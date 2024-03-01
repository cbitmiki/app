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
       public static void InitializeGame()
       {
        Word.InitializeGameBoard(Word.GetWordStringLength(Word.GetAWord())); 
       }
    }
}