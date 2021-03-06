﻿using System;

namespace _7._Knight_Game
{
    class KnightGame
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] rowInput = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowInput[j];
                }
            }

            int counterRemovedKnights = 0;
            bool fight = true;
            int x = -1, y = -1;

            while (true)
            {
                //fight = false;
                int maxCount = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        int count = 0;
                        if (matrix[i, j] == 'K')
                        {
                            if (ValidPosition(i - 2, j - 1, matrix))
                            {
                                if (matrix[i - 2, j - 1] == 'K')
                                { 
                                    count++;
                                }
                            }
                            if (ValidPosition(i - 2, j + 1, matrix))
                            {
                                if (matrix[i - 2, j + 1] == 'K')
                                {
                                    count++;
                                }
                            }
                            if (ValidPosition(i - 1, j - 2, matrix))
                            {
                                if (matrix[i - 1, j - 2] == 'K')
                                {
                                    count++;
                                }
                            }
                            if (ValidPosition(i - 1, j + 2, matrix))
                            {
                                if (matrix[i - 1, j + 2] == 'K')
                                {
                                    count++;
                                }
                            }
                            if (ValidPosition(i + 1, j - 2, matrix))
                            {
                                if (matrix[i + 1, j - 2] == 'K')
                                {
                                    count++;
                                }
                            }
                            if (ValidPosition(i + 1, j + 2, matrix))
                            {
                                if (matrix[i + 1, j + 2] == 'K')
                                {
                                    count++;
                                }
                            }
                            if (ValidPosition(i + 2, j - 1, matrix))
                            {
                                if (matrix[i + 2, j - 1] == 'K')
                                {
                                    count++;
                                }
                            }
                            if (ValidPosition(i + 2, j + 1, matrix))
                            {
                                if (matrix[i + 2, j + 1] == 'K')
                                {
                                    count++;
                                }
                            }
                        }
                        if (maxCount < count)
                        {
                            maxCount = count;
                            x = i;
                            y = j;
                            //fight = true;
                        }
                    }
                }
                //if (fight == true)
                if(maxCount>0)
                {
                    matrix[x, y] = '0';
                    counterRemovedKnights++;
                }
                else
                {
                    Console.WriteLine(counterRemovedKnights);
                    return;
                }
            }

        }

        private static bool ValidPosition(int x, int y, char[,] matrix)
        {
            if (x < 0 || y < 0)
            {
                return false;
            }
            if (x > matrix.GetLength(0) - 1 || y > matrix.GetLength(1) - 1)
            {
                return false;
            }
            return true;
        }
    }
}
