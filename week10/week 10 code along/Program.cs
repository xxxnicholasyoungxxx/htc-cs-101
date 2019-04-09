using System;
using System.Collections.Generic;

namespace week_10_code_along
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To-Do List");
            List<string> toDoList = new List<string>();

            while (true) {
                Console.WriteLine("Enter Command..");
                string command = Console.ReadLine();

                    if (command == "Add") {
                        Console.WriteLine("Enter an item: ");
                        string item = Console.ReadLine();
                        toDoList.Add(item);
                    } else if (command == "View") {
                        viewList(toDoList);
                    } else if (command == "Exit") {
                        break;
                    }
            }
        }
        public static void viewList(List<string> stringList) {
            int toDoCount = stringList.Count;
                if (toDoCount == 0) {
                    Console.WriteLine("You have nothing to do..");
                } else if (toDoCount == 1) {
                    Console.WriteLine(toDoCount + " thing left to do..");
                        Console.WriteLine("To Do: ");
                        foreach (string item in stringList) {
                            Console.WriteLine("- " + item);
                        }
                } else {
                    Console.WriteLine(toDoCount + " things left to do..");
                        Console.WriteLine("To Do: ");
                    foreach (string item in stringList) {
                        Console.WriteLine("- " + item);
                    }
                }
            
        }
    }
}
