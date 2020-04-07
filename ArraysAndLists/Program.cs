using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] arr = new int[11];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = i;
            }
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
            for (int i = 1; i < arr.Length; i++) 
            {
               if (i % 2 == 0)
               {
                   evens.Add(i);
               }
               else
               {
                   odds.Add(i);
               }
            }
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Even numbers:");
            foreach (int num in evens)
            {
               Console.WriteLine(num);
            }

            Console.WriteLine("Odd numbers:");
            foreach (int num in odds)
            {
               Console.WriteLine(num);
            }
        }
    }
}
