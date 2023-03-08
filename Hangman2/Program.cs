using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace Hangman
{
    class Program
    {
        static string correctWord;
        static List<char>? letters;
        static Player player;

        static void Main(string[] args)
        {

            try
            {
                StartGame();
                PlayGame();
                EndGame();
            }
            catch
            {
                WriteLine("Oops, something went wrong...");
            }

        }

        private static void StartGame()
        {
            string correctWord = "butter";

            List<char> charList = new List<char>(correctWord.ToCharArray());

            foreach (char c in correctWord)
            {
                Write('-');
            }

            WriteLine();
            Askforusersname();
        }

        static void Askforusersname()
        {
            WriteLine("Enter your name:");
            string input = ReadLine();

            if (input.Length >= 2)
                player = new Player(input);
            else
            {
                // the user entered an invalid name
                Askforusersname();
            }
        }

        private static void PlayGame()
        {
            do
            {
                Clear();
                DisplayMaskedWord();
                char guessedLetter = AskForLetter();
                CheckLetter(guessedLetter);
            } while (correctWord != new string(letters.ToArray()));

            Clear();
        }

        private static void CheckLetter(char GuessedLetter)
        {
            int i = 0;
            foreach (char correctChar in correctWord)
            {
                if (GuessedLetter == correctChar)
                {
                    letters[i] = GuessedLetter;
                    player.Score++;
                }
                i++;
            }

        }

       static void DisplayMaskedWord()
       {
       foreach (char c in letters)
       Write(c);

       WriteLine();
       }

       static char AskForLetter()
       {
       string input;
       do
        {
            //Rejex toets...
            WriteLine("Enter a letter:");
            input = ReadLine();
        } while (input.Length != 1);

        var letter = input[0];

        if (Player.GuessedLetters.contains(letter))
             Player.GuessedLetters.add(letter);

                return letter;
       }

            private static void EndGame()
            {
                Console.WriteLine("Congrats!");
                Console.WriteLine($"Thanks for playing {player.Name}!");
                Console.WriteLine($"Guesses:{player.GuessedLetters.Count} Score:{player.Score}");
            }

        }

    }

}