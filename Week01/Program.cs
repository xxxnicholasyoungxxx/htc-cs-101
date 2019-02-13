using System;

namespace Week01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            string userName = "Nick";
            int userAge = 15;
            int numberOfPets = 9001;
            string schoolAttended = "Mildeau Moldies";

            Console.WriteLine("Sup, my name is " + userName);
            //sup my name is Nick

            Console.WriteLine(String.Format("I am {0} yrs old and own {1} pet", userAge, numberOfPets));
            
            Console.WriteLine($"i went to school at {schoolAttended}!");

            Random rng = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rng.Next(0, 25));
            }
        }
    }
}
