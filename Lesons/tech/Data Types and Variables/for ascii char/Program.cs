﻿using System;

namespace for_ascii_char
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (char i =(char) start; i <(char) end; i++)
            {
                Console.WriteLine(i+" ");
            }
        }
    }
}
