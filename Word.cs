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
        public static string GetWord()
        {
            string[] allLines = File.ReadAllLines(@"/Users/b5gaming/app/Words.txt");
            Random r = new Random();
            return (allLines[r.Next(0,allLines.Length-1)]);
        }
    } 
}