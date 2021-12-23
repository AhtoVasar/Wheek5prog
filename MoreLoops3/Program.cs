using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängiat + arvuti (cpu) ja kasutaja (user);
            //mõlemad mängiad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskab rohkem, ongi mängu võitja;
            //*täringuid visatakse kolm korda;
            //programm kuulutab võitjat.

            Random rnd = new Random();

            for (int i = 0; i < 3; i++)

            {

                //Arvuti vise;
                int cpuRandom = rnd.Next(1, 7);
                //Kasutaja vise;
                int userRandom = rnd.Next(1, 7);

                int cpuScore = 0;
                int userScore = 0;

                Console.WriteLine($"Aruti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mängu võitnud.");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }

                Console.WriteLine($"Arvuti skoor:{cpuScore} ja kasutaja skoor:{userScore}");


            }
        }
    }
}