using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            int getpower(int num, int power)
            {
                if (power == 0)
                {
                    Console.WriteLine("Нулевой степени числа не существует");
                    return -1;
                }
                else 
                {
                    if (num == 0) return 0;
                    else if (num == 1) return 1;
                    else
                    {
                        int res = num;
                        for (int i=1; i<power; i++)
                        {
                            res = res*num;
                        }
                        return res;
                    }
                }
            }
            Console.Write("Введите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(getpower(a,b));
        }
    }
}