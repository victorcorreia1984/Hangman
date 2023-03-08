namespace Hangman
{
    class Program
    {
        static string naam;
        static string raaiSkoot;
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
            SkepLetters();
        }

        static void KryNaam()
        {
            Console.WriteLine("Wat is jou naam?:");
            string input = Console.ReadLine();

            if (input.Length >= 2)
                naam = input; //Gebruiker het 'n geldige naam ingevul
            else
                KryNaam();
        }

        static void SkepLetters()
        {
            letters = new char[Antwoord1.Length];
            for (int i = 0; i < Antwoord1.Length; i++)
                letters[i] = '-';
        }

        private static void SpeelSpel()
        {
            VertoonVersteekteWoord();
            char raaiSkoot = VraVirLetter();
            ToetsLetter(raaiSkoot);
        }

        private static void ToetsLetter(char raaiSkoot)
        {
            for (int i = 0; i < Antwoord1.Length; i++)
            {
                if (raaiSkoot == letters[i])
                    letters[i] = raaiSkoot;
                Console.Write(letters[i]);
            }
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

            string raaiSkoot;
            do
            {
                Console.WriteLine("Tik 'n letter in:");
                input = Console.ReadLine();
            } while (raaiskoot.Length != 1);

            AantalPogings++;

            return raaiSkoot[0];
        }

        private static void EindigSpel()
        {
            Console.WriteLine("Totsiens");
            Console.WriteLine($"Dankie vir jou deelname {naam}");
            Console.WriteLine($"Aantalpogings: {AantalPogings}");
            Console.WriteLine($"{letters}");
        }

    }
}