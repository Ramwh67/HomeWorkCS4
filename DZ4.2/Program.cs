using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            int getSumOfDigits(int num)
            {
                string str = num.ToString();
                int[] array = new int[str.Length];
                int sum = 0;
                for (int i=0; i<str.Length; i++)
                {
                    array[i] = int.Parse(str[i].ToString());
                    sum = sum + array[i];
                }
                return sum;
            }
            Console.Write("Введите целое число ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(getSumOfDigits(number));
        }
    }
}