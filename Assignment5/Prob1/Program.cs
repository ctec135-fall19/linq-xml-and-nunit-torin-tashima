/*
Author: Torin Tashima
Date:   November 2, 2019
CTEC 135: Microsoft Software Development with C#

Module 6, Programming Assignment 5, Problem 1

    LINQ

    1. Create a static method that
        - creates an array of strings (the ordering of the strings should
            be random)
        - create a LINQ statement that returns the strings that start with
            'a' - 'f'
        - output the result 
        - modify the array in such a way that the result will be different
        - output the result again
        - modify the array in such a way that the result will be different
        - capture the result as a List<string> object and return it
    2. in Main, output the returned result

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animalList = LinqStringMethod();

            Console.WriteLine("Edited string array" +
                " (every second element is trimmed down to 2 characters):");
            foreach (string animal in animalList)
            {
                Console.WriteLine("\t{0}", animal);
            }
        }

        // Input: N/A
        // Process: Shown in step 1 in the problem description
        // Output: Modified array as a string list
        static List<string> LinqStringMethod()
        {
            // Create an array of strings
            string[] stringArray = { "giraffe", "bear", "fox", "kangaroo",
                "hippo", "elephant", "alligator", "iguana", "cat", "dog" };

            // Create LINQ statement to return strings starting with 'a' - 'f'
            var subset = from animal in stringArray
                         where animal[0] >= 'a' && animal[0] <= 'f'
                         orderby animal
                         select animal;

            // Print results
            Console.WriteLine("Animals that start with 'A' to 'F':");
            foreach (var s in subset)
            {
                Console.WriteLine("\t{0}", s);
            }
            Console.WriteLine();

            // Array modification #1
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (i % 3 == 0)
                {
                    string revisedString = stringArray[i].Substring(1);
                    stringArray[i] = revisedString;
                }
            }

            // Create LINQ statement to return strings starting with 'a' - 'f'
            var subset2 = from animal in stringArray
                         where animal[0] >= 'a' && animal[0] <= 'f'
                         orderby animal
                         select animal;

            // Print results again
            Console.WriteLine("Edited string array" +
                " (every third element has starting letter removed):");
            foreach (var s in subset2)
            {
                Console.WriteLine("\t{0}", s);
            }
            Console.WriteLine();

            // Array modification #2
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (i % 2 == 1)
                {
                    string revisedString = stringArray[i].Substring(0, 2);
                    stringArray[i] = revisedString;
                }
            }

            // Create LINQ statement to return strings starting with 'a' - 'f'
            List<string> outputList = new List<string>
                          (from animal in stringArray
                          where animal[0] >= 'a' && animal[0] <= 'f'
                          orderby animal
                          select animal);

            return outputList;
        }
    }
}
