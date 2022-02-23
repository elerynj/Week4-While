using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab juhusliku numbri ära arvama;
            //kui kasutaja arvas juhusliku numbri ära, siis on ta mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme korraga numbrit ära arvata, siis on arvuti võitnud;
            //*programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Tere tulemast numbrimängu! Mängu võitmiseks tuleb number 1 kuni 10 ära arvata.");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber == userNumber)
                {
                    Console.WriteLine("Palju õnne! Oled mängu võitnud!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number. {3 - i} katset on jäänud. Proovi uuesti!");
                }

                Console.WriteLine("Kena päeva!");
            }
        }
    }
}
