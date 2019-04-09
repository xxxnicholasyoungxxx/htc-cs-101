using System;

namespace week10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to go for an adventure?");
            string ans = Console.ReadLine();
                if (ans == "yes" || ans == "Yes" || ans == "YES") {
                    Console.WriteLine("Good..");
                } else {
                    Console.WriteLine("Too bad!");
                }
            Console.WriteLine("Pick a number, one through three..");
            int num = Convert.ToInt32(Console.ReadLine());
            int z = 1;
                while (z == 2) {
                    if (num == 1) {
                        Console.WriteLine("1");
                        z++;
                    } else if (num == 2) {
                        Console.WriteLine("2");
                        z++;
                    } else if (num == 3) {
                        Console.WriteLine("3");
                        z++;
                    } else {
                        Console.WriteLine("Number between one through three..");
                    }
                }
        }
    }
}
