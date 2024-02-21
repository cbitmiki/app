using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace app.obj
{
    public class Word
    {
        public static string GetAWord()
        {
            string[] allLines = File.ReadAllLines(@"C:\Users\Gamer\app\obj\Words.txt");
            Random r = new Random();
            return (allLines[r.Next(0,allLines.Length)]);
        }

    }
}