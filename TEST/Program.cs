using System;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Do you want to play a game?");
            string ans = Console.ReadLine();
                if (ans == "yes" || ans == "Yes" || ans == "YES" || ans == "sure" || ans == "ye") {
                    Console.WriteLine("Good..");
                } else {
                    Console.WriteLine("Too bad!");
                }
                while (true) {
                    Console.WriteLine("Pick a number, one through three..");
                    int num = Convert.ToInt32(Console.ReadLine());
                        if (num == 1) {
                            Console.WriteLine("1");
                            break;
                        } else if (num == 2) {
                            Console.WriteLine("2");
                            break;
                        } else if (num == 3) {
                            Console.WriteLine("3");
                            break;
                        } else {
                            Console.WriteLine("Pick a number between one through three..");
                        }
                }
            if (num == 1) {
                Console.WriteLine("Lets play Tic-Tac-Toe");
            } else if (num == 2) {
                Console.WriteLine("Try to guess a number I am thinking of");
            } else if (num == 3) {

            }*/
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

                for(int i = 0; i <= 8; i++) {
                    LISTLIST(listList);
                    viewList(listList);
                }
        }
        public static void LISTLIST(List<string> listList) {
            Console.WriteLine("Give a number 1-9");
            int player = Convert.ToInt32(Console.ReadLine());
            listList[player-1] = "X";

            Random rnd = new Random();
            int guesser  = rnd.Next(1, 10);

                while (player == guesser) {
                    guesser  = rnd.Next(1, 10);
                }

            listList[guesser-1] = "O";

        }
        public static void viewList(List<string> listList) {
            Console.WriteLine(listList[0] + "_|_" + listList[1] + "_|_" + listList[2] );
            Console.WriteLine(listList[3] + "_|_" + listList[4] + "_|_" + listList[5] );
            Console.WriteLine(listList[6] + " | " + listList[7] + " | " + listList[8] );
        }

    }
}