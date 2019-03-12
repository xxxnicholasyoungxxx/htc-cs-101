using System;

namespace week_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme a numbah");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What number do you want to end at??");
            int end = Convert.ToInt32(Console.ReadLine());

            while (x < end) {
                x++;
                //Console.WriteLine(x);
                    if (x % 2 == 0) {
                        Console.WriteLine("This number is even");
                        Console.WriteLine(x);
                    } else {
                        //Console.WriteLine("This number is odd");
                    }
            }

            /*if (x % 2 == 0) {
                Console.WriteLine("This number is even");
            } else {
                Console.WriteLine("This number is odd");
            }*/

        }
    }
}
