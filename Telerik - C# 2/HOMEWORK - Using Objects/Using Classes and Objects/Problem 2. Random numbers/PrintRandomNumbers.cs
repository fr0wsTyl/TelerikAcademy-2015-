﻿//Write a program that generates and prints to the console 10 random values in the range [100, 200].
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Random_numbers
{
    class PrintRandomNumbers
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num.Next(100, 200));
            }
        }
    }
}
