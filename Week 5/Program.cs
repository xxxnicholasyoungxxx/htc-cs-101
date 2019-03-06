using System;

namespace Week_5
{
    class Program
    {

        static void Main(string[] args)
        {

            int something = 0;
            OutArgExample(out something);
            Console.WriteLine(something);

            OutArgExample(out something);
            Console.WriteLine(something);

           /* int returnValue = 0;

            Console.WriteLine("What operation to perform?");
            string operation = Console.ReadLine();

            Console.WriteLine("Enter a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter c:");
            int c = Convert.ToInt32(Console.ReadLine());

            if (operation == "+") {
                // add the numbers
                returnValue = AddNumbers(a, b);
            }
            else if (operation == "-") {
                // minus the number
                returnValue = MinusNumbers(a, b);
            }
            else if (operation == "x") {
                // Multiply
                returnValue = MultiplyNumbers(a, b);
            }
            else if (operation == "/") {
                // division
                returnValue = DivideNumbers(a, b);
            }
            else if (operation == "quadratic") {



            }
            else {
                Console.WriteLine("Type in a math operation");
            }

            Console.WriteLine(returnValue);
*/
        }

        public static int AddNumbers(int integer1, int integer2)
        {
            return integer1 + integer2;
        }

        public static int MinusNumbers(int integer1, int integer2)
        {
            return integer1 - integer2;
        }

        public static int MultiplyNumbers(int integer1, int integer2)
        {
            return integer1 * integer2;
        }
        public static int DivideNumbers(int integer1, int integer2)
        {
            return integer1 / integer2;
        }

        public static int QuadraticNum(int a, int b, int c) 
        {
            return 1;
        }
        public static void OutArgExample(out int number1, out int number2)
        {
            number1 = 44;
            number2 = 5;
        }

    }
}
