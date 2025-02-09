﻿/* 
 Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Quadratic_Equation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            //D formula -> b^2 - 4 * a * c
            double d = Math.Pow(b, 2) - 4 * (a) * (c);
            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);
            
            if(!double.IsNaN(x1) && !double.IsNaN(x2))
            {
                Console.WriteLine("x1 = {0} x2 = {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
