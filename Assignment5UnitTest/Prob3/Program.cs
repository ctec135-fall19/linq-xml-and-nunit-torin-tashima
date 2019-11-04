/*
Author: Torin Tashima
Date:   November 2, 2019
CTEC 135: Microsoft Software Development with C#

Module 6, Programming Assignment 5, Problem 3

    NUnit

    1. Repeat this assignment on your own machine. 
    2. BONUS: create your own class and methods and associated test library
        and tests.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Add method from MyMath1 class
            Console.WriteLine("96 + 96 = {0}", MyMath1.Add((byte)96, (byte)96));
            Console.WriteLine("160 + 160 = {0}", MyMath1.Add(160, 160));

            // Test Add method from MyMath2 class
            Console.WriteLine("96 + 96 = {0}", MyMath2.Add((byte)96, (byte)96));
            try
            {
                Console.WriteLine("160 + 160 = {0}", MyMath2.Add(160, 160));
            }
            catch
            {
                Console.WriteLine("160 + 160 = Overflow Error");
            }
        }
    }
}
