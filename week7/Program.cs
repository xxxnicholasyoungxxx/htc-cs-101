using System;

namespace week7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type a number plez");
            int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= num; i++) {
                    if (i % 3 == 0 && i % 5 == 0) {
                        Console.WriteLine("FIZZBUZZ");
                    } else if (i % 3 == 0) {
                        Console.WriteLine("FIZZ");
                    } else if (i % 5 == 0) {
                        Console.WriteLine("BUZZ");
                    } else {
                        Console.WriteLine(i);
                    }
                }
        
        
        }
    }
}
