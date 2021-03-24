using System;

namespace Programming1Lab8Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming 1 Lab 8 Task 4.\n\n" +
                              "This is a program that plays out a chase between the SkiFree© skier and the abominable snow monster\n" +
                              "The Skier will try to get 2000 metres down the slope before the Abominable Snow Monster catches him and\n" +
                              "he becomes tea for the monster.\n\n");

            Random rand = new Random();
            int skierDistance, absDistance, abs;
            skierDistance = absDistance = abs = 0;

            skierDistance = rand.Next(20);
            abs = rand.Next(10);
            absDistance = skierDistance + abs;

            ReportDistances(skierDistance, absDistance);
            
            while(skierDistance < 2000 && (absDistance > skierDistance))
            {
                skierDistance += rand.Next(5);
                absDistance += rand.Next(5);
                ReportDistances(skierDistance, absDistance);
            }
            
            if(skierDistance >= 2000)
            {
                Console.WriteLine("\n\nThe skier made it and got away scot free! The Abominable Snow Monster stays hungry tonight.");
            }

            else
            {
                Console.WriteLine("\n\nSomeone call the ambulance! Or maybe the morgue..\n" +
                                  "The Abominable Snow Monster caught up to the Skier and now he is using a skipole to pick " +
                                  "the Skier's flesh out of his teeth.");
            }


            Console.ReadLine();
        }

        static void ReportDistances(int skier, int abs)
        {
            Console.WriteLine($"The Skier is {skier} metres down the slope. " +
                              $"The Abominable Snow Man is {abs - skier} metres from the Skier.");
        }
    }
}
