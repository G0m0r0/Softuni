﻿using System;

namespace even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while(num%2!=0)
            {
                Console.WriteLine("Please write an even number.");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}",Math.Abs(num));
        }
    }
}
