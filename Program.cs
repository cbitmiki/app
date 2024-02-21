using app.obj;

Console.Title = "Hangman";


HangmanGame.PrintGameBoard(HangmanGame.GetGameStringLength(Word.GetAWord()));
Console.WriteLine(Word.GetAWord());