﻿using System;

namespace Week_3_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number between 1 and 10");
            int num = Convert.ToInt32(Console.ReadLine());
                if (num > 4) {
                    Console.WriteLine("Too High");
                }
                else if (num < 4) {
                    Console.WriteLine("Too Low");
                }
                else {
                    Console.WriteLine("Just Right");
                }
        
        }
    }
}
