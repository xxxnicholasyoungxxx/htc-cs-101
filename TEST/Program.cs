using System;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listList = new List<string>();
            listList.Add(" ");
            listList.Add(" ");
            listList.Add(" ");
            listList.Add(" ");
            listList.Add(" ");
            listList.Add(" ");
            listList.Add(" ");
            listList.Add(" ");
            listList.Add(" ");
            bool returnValue = false;

            while (!returnValue)
            {
                viewList(listList);
                LISTLIST(listList);
                returnValue = win(listList);
            }
            viewList(listList);
            returnValue = win(listList);
        }
        public static void LISTLIST(List<string> listList)
        {
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Give a number 1-9");
                    int player = Convert.ToInt32(Console.ReadLine());
                    if (listList[player - 1] == " ")
                    {
                        listList[player - 1] = "X";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Choose a differ spot..");
                    }
                }

                while (true)
                {
                    Random rnd = new Random();
                    int guesser = rnd.Next(1, 10);
                    if (listList[guesser - 1] == " ")
                    {
                        listList[guesser - 1] = "O";
                        break;
                    }
                    else { }
                }
                break;
            }
        }
        public static void viewList(List<string> listList)
        {
            Console.WriteLine(listList[6] + "_|_" + listList[7] + "_|_" + listList[8]);
            Console.WriteLine(listList[3] + "_|_" + listList[4] + "_|_" + listList[5]);
            Console.WriteLine(listList[0] + " | " + listList[1] + " | " + listList[2]);
        }
        public static bool win(List<string> listList)
        {
            if ((listList[0] == "X") && (listList[1] == "X") && (listList[2] == "X"))
                    {
                        Console.WriteLine("X wins");
                        return true;
                    }
                    else if ((listList[3] == "X") && (listList[4] == "X") && (listList[5] == "X"))
                    {
                        Console.WriteLine("X wins");
                        return true;
                    }
                    else if ((listList[6] == "X") && (listList[7] == "X") && (listList[8] == "X"))
                    {
                        Console.WriteLine("X wins");
                        return true;
                    }
                    else if ((listList[0] == "X") && (listList[3] == "X") && (listList[6] == "X"))
                    {
                        Console.WriteLine("X wins");
                        return true;
                    }
                    else if ((listList[1] == "X") && (listList[4] == "X") && (listList[7] == "X"))
                    {
                        Console.WriteLine("X wins");
                        return true;
                    }
                    else if ((listList[2] == "X") && (listList[5] == "X") && (listList[8] == "X"))
                    {
                        Console.WriteLine("X wins");
                        return true;
                    }
                    else if ((listList[0] == "X") && (listList[4] == "X") && (listList[8] == "X"))
                    {
                        Console.WriteLine("X wins");
                        return true;
                    }
                    else if ((listList[2] == "X") && (listList[4] == "X") && (listList[6] == "X"))
                    {
                        Console.WriteLine("X wins");
                        return true;
                    }
                    else if ((listList[0] == "O") && (listList[1] == "O") && (listList[2] == "O"))
                    {
                        Console.WriteLine("O wins");
                        return true;
                    }
                    else if ((listList[3] == "O") && (listList[4] == "O") && (listList[5] == "O"))
                    {
                        Console.WriteLine("O wins");
                        return true;
                    }
                    else if ((listList[6] == "O") && (listList[7] == "O") && (listList[8] == "O"))
                    {
                        Console.WriteLine("O wins");
                        return true;
                    }
                    else if ((listList[0] == "O") && (listList[3] == "O") && (listList[6] == "O"))
                    {
                        Console.WriteLine("O wins");
                        return true;
                    }
                    else if ((listList[1] == "O") && (listList[4] == "O") && (listList[7] == "O"))
                    {
                        Console.WriteLine("O wins");
                        return true;
                    }
                    else if ((listList[2] == "O") && (listList[5] == "O") && (listList[8] == "O"))
                    {
                        Console.WriteLine("O wins");
                        return true;
                    }
                    else if ((listList[2] == "O") && (listList[5] == "O") && (listList[8] == "O"))
                    {
                        Console.WriteLine("O wins");
                        return true;
                    }
                    else if ((listList[2] == "O") && (listList[5] == "O") && (listList[8] == "O"))
                    {
                        Console.WriteLine("O wins");
                        return true;
                    }
                    else if ((listList[0] != " ") && (listList[1] != " ") && (listList[2] != " ") && (listList[3] != " ") && (listList[4] != " ") && (listList[5] != " ") && (listList[6] != " ") && (listList[7] != " ") && (listList[8] != " "))
                    {
                        Console.WriteLine("Cats game");
                        return true;
                    }
                    else 
                    {
                        Console.WriteLine("Cats game");
                        return false;
                    }
        }

    }
}