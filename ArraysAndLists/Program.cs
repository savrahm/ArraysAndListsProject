using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace ArraysAndLists
{
    class Program
    {
        public static double FindAverage(double[] array)
        {
            double sum = array.Sum();
            double index = 1;

            while (index < array.Length)
            {
                index++;
            }

            return sum / index;
        }

        static void Main(string[] args)
        {
            double[] testArray = { 1, 2, 3 };
            Console.WriteLine(Program.FindAverage(testArray));

            //TODO:

            // Create an int Array and populate numbers 1-10

            int[] practiceArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (var num in practiceArray)
                if (num % 2 == 0)
                    evens.Add(num);
                else
                    odds.Add(num);


            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Our evens:");
            foreach (var even in evens)
                Console.WriteLine(even);
            Console.WriteLine("Our odds:");
            foreach (var odd in odds)
                Console.WriteLine(odd);

        }

    }
}

