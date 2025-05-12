using System;
using System.Media;



class GameDemo
{
    static void Main(string[] args)
    {
        string correctSoundPath = "correct.wav";
        string incorrectSoundPath = "incorrect.wav";

        AskQuestion("What is the capital of France?", "paris", correctSoundPath, incorrectSoundPath);
        AskQuestion("What is 2 + 2?", "4", correctSoundPath, incorrectSoundPath);
    }

    static void AskQuestion(string question, string correctAnswer, string correctSoundPath, string incorrectSoundPath)
    {
        Console.WriteLine(question);
        string answer = Console.ReadLine()?.Trim().ToLower();

        if (answer.Equals(correctAnswer))
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("Correct!");
            PlaySound(correctSoundPath);
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Incorrect.");
            PlaySound(incorrectSoundPath);
        }

        Console.ResetColor();
    }

    static void PlaySound(string soundFilePath)
    {
        try
        {
            using (SoundPlayer player = new SoundPlayer(soundFilePath))
            {
                player.PlaySync();
            }
        }
        catch { }
    }
}


