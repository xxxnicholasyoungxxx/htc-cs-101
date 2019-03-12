using System;

namespace week_6_challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            bool playAgain = true;

            while (playAgain == true) {

                

                Console.WriteLine("Guess a number 1-20 that I am thinking of..");
                int x = Convert.ToInt32(Console.ReadLine());

                Random rnd = new Random();
                int sumfin = rnd.Next(20);

                //Console.WriteLine(sumfin);

                    while (x != sumfin) {

                        if (x > sumfin) {
                            //Too high
                            Console.WriteLine("Too high");
                        } else if (x < sumfin) {
                            //Too low
                            Console.WriteLine("Too low");
                        }
                        Console.WriteLine("Guess again");
                        x = Convert.ToInt32(Console.ReadLine());

                    }

                Console.WriteLine("You guessed it!!");

                Console.WriteLine("Wanna try again?? true or false");
                bool play = Convert.ToBoolean(Console.ReadLine());

                playAgain = play;

            }

        }
    }
}
