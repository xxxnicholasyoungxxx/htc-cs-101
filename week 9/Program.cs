using System;

namespace week_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many? ;))");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0) {
                PrintSmileys(num);
            } else {
                Console.WriteLine("Bigger number bruh");
            }
        }

        public static void PrintSmileys(int numTimes)
        {
            for (int i = 0; i < numTimes; i++) {
                Console.WriteLine("( ͜。 ͡ʖ ͜。)[̲̅$̲̅(̲̅5̲̅)̲̅$̲̅]");
            }
        }

    }
}
