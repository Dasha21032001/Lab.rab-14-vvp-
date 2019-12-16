using System;

namespace задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов в массиве:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < N; i++)
            {
                int c = Convert.ToInt32(Console.ReadLine());
                A[i] = c;
            }
            int min = 100000000;
            for (int i = 0; i < N; i++)
            {
                if (i % 2==0)
                {
                    if (A[i] < min)
                    {
                        min = A[i];
                    }
                }
            }
            Console.WriteLine("Минимальный элемент из элементов с четными номерами:" + min);
            Console.ReadLine();
        }
    }
}   

