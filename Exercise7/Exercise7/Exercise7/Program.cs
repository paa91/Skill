﻿using System;

namespace Exercise 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            int[][] numbers = new int[3][];
            numbers[0] = new int[] { 1, 2 };
            numbers[1] = new int[] { 1, 2, 3 };
            numbers[2] = new int[] { 1, 2, 3, 4, 5 };
            foreach (int[] row in numbers)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }

            // перебор с помощью цикла for
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.Write($"{numbers[i][j]} \t");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}