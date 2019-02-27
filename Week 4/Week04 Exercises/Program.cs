using System;

namespace Week04_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
        /* PART 1
        1. false
        2. true
        3. true
        4. false
        5. true
        6. true
        7. false
        PART 2
        1. false
        2. true
        3. false
        4. true
        5. true
        6. false
        7. false
        8. false
        9. false
        10. true
        11. true*/

        Console.WriteLine("What day is it?");
        string dayOfWeek = Console.ReadLine();
        Console.WriteLine("Time of Day? Military time..");
        string timeOfDay = Console.ReadLine();
        Console.WriteLine("How long are you parking? Military time..");
        string timeForParking = Console.ReadLine();

        if (dayOfWeek == "monday" || "tuesday" || "wedensday" || "thursday") {
            if (timeForParking == 2) {
                if ((1800<=timeOfDay) && (timeOfDay<=2200)) {
                    Console.WriteLine("You can park!");
                } else {
                    Console.WriteLine("You cannot park here, if you try, then you will be towed.");
                }
            } else if (timeForParking == 4) {
                if ((2200<=timeOfDay) && (timeOfDay<=0200)) {
                    Console.WriteLine("You can park!");
                } else {
                    Console.WriteLine("You cannot park here, if you try, then you will be towed.");
                }
            } else {
                Console.WriteLine("You cannot park here, if you try, then you will be towed.");
            }
        } else if (dayOfWeek == "friday" || "saturday") {
            if (timeForParking == 2) {
                if ((1800<=timeOfDay) && (timeOfDay<=2400)){
                    Console.WriteLine("You can park!");
                } else {
                    Console.WriteLine("You can't park!");
                }
            }
        } else {
            Console.WriteLine("You can't park!");
        }

        }
    }
}
