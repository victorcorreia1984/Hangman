using System.Diagnostics.Metrics;

namespace Hangman
{
    class Program
    {
        static string naam;
        static char[] letters;
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
            KryNaam();
            KryLetters();
        }

        static void KryNaam()
        {
           Console.WriteLine("Wat is jou naam?:");
           string input = Console.ReadLine();

            if (input.Length >= 2)
                naam = input; //Gebruiker het 'n geldige naam ingevul
            else       
                KryNaam();
            
           Console.WriteLine($"Welkom {naam} ");
        }

        static void KryLetters()
        {
            letters = new char[Antwoord1.Length];
            for (int i = 0; i < Antwoord1.Length; i++)
                letters[i] = '-';
        }

        private static void SpeelSpel()
        {
            Console.WriteLine("Raai die volgende woord!");
            VertoonVersteekteWoord();
            VraVirLetter();
            TeksNaKarakter();
            DrukKarakter();
        }

        static void VertoonVersteekteWoord()
        {
            foreach (char c in letters)
                Console.Write(c);

            Console.WriteLine();
        }

        static char VraVirLetter()
        { 
               
            
            //Voeg 'n boodskap by wat foutkode aandui (Verander met while)
            
            string input; 
            do
            {
              Console.WriteLine("Tik 'n letter in:");
              input = Console.ReadLine();
            } while (input.Length != 1);

            AantalPogings++;

            return input[0];
        }

        static void TeksNaKarakter()
        {
            char[] karReeks = Antwoord1.ToCharArray();

            for (int i = 0; i < karReeks.Length; i++)
            {
                char ch = karReeks[i];
            }
        }

        static void DrukKarakter()
        {

        }




        private static void EindigSpel()
        {
            Console.WriteLine("Totsiens");
            Console.WriteLine($"Dankie vir jou deelname {naam}");
            Console.WriteLine($"Aantalpogings: {AantalPogings}");
        }

    }
}