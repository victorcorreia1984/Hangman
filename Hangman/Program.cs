using System.Diagnostics.Metrics;

namespace Hangman
{
    class Program
    {
        static string naam;
        static int AantalPogings;
        static string Antwoord1 = "hangman";
       
        static void Main(string[] args)
        {
            BeginSpel();
            SpeelSpel();
            EindigSpel();
        }

        private static void BeginSpel()
        {
            Console.WriteLine("Begin die spelletjie...");
            KryNaam();
        }

        static void KryNaam()
        {
           Console.WriteLine("Wat is jou naam?:");
           string input = Console.ReadLine();

            if (input.Length >= 2)
                naam = input; //Gebruiker het 'n geldige naam ingevul

            else       
            {
                KryNaam();
            }

        }

        private static void SpeelSpel()
        {
            Console.WriteLine("Raai die volgende woord!");
            VertoonVersteekteWoord();
            VraVirLetter();
        }

        static void VertoonVersteekteWoord()
        {
            foreach (char c in Antwoord1)
            {
                Console.Write("_ ");
            }
            Console.WriteLine();
        }

        static void VraVirLetter()
        {

            foreach (var item in Antwoord1)
            {
                string input;
                do
                {
                    Console.WriteLine("Tik 'n letter in:");
                    input = Console.ReadLine();
                } while (input.Length != 1);

                AantalPogings++;
            }
        }

        private static void EindigSpel()
        {
            Console.WriteLine("Totsiens");
            Console.WriteLine($"Dankie vir jou deelname {naam}");
            Console.WriteLine($"Aantalpogings: {AantalPogings}");
        }

    }
}