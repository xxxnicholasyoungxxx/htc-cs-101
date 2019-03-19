using System;

namespace week_7_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in an ending point..");
            int topNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Where do you want to start counting??");
            int botNum = Convert.ToInt32(Console.ReadLine());

                int sum = 0;

                        for (int i = botNum; i <= topNum; i++) {
                            sum = i + sum;
                        }
                    Console.WriteLine(sum);            
        }
    }
}
