﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer: ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first integer:");
            int num2=Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
            Console.ReadLine();
        }
    }
}
