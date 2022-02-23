using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab juhusliku numbri ära arvama;
            //kui kasutaja arvas juhusliku numbri ära, siis on ta mängu võitnud;
            //katsete arv on piiramatu;
            //*programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Tere tulemast numbrimängu! Mängu võitmiseks tuleb number 1 kuni 10 ära arvata.");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if(userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! Oled mängu võitnud!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale number. Proovi uuesti!");
                    Console.WriteLine($"Oled sisestanud vale numbri {i} korda.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
