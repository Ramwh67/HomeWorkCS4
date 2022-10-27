﻿using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] createNewArray(int size)
            {
               int[] array = new int[size];
               for (int i=0; i<size; i++)
               {
                    array[i] = new Random().Next(0,100);
               }
               return array;
            }
            
            void printArray(int[] array)
            {
                for (int i=0; i<array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }
 
            Console.Write("Введите размерность массива: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] numbers = createNewArray(a);
            printArray(numbers);
        }
    }
}