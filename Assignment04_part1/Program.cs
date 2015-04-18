using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // random number generator
            Random randomNumbers = new Random();

            // When you roll two dice, there are 11 possible sums:
            int[] totaldie = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // for 36,000 times, roll two dice, calculate the sum,
            // and increment the index corresponding to that sum.
            for (int roll = 0; roll < 36000; roll++)
            {
                totaldie[randomNumbers.Next(1, 7) + randomNumbers.Next(1, 7)]++;
            }

            //display the face and frequnecy
            Console.WriteLine("{0}{1,10}", "Face", "Frequency");

            //output how many times each array elemtns value comes up
            int throws = 0;
            for (int face = 2; face < totaldie.Length; face++)
            {
                Console.WriteLine("{0,4}{1,10}", face, totaldie[face]);
                throws += totaldie[face];
            }

            //display the total throw times
            Console.WriteLine("Throws = {0}", throws);

            waitForAnyKey();
        }

        private static void waitForAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++                  Press any key to continue...             +++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
    

