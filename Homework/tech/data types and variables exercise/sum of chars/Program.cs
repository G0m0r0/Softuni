﻿using System;

namespace sum_of_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                sum += ch;
            }
            Console.WriteLine("The sum equals: {0}",sum);
        }
    }
}
