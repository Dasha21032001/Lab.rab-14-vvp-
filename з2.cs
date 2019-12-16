using System;

namespace задание_2
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
            int d = A[1] - A[0];
            for (int i = 1; i < N; i++)
            {
                if ((A[i+1]-A[i]) != d)
                {
                    Console.WriteLine("Элементы массива не образуют арифметическую прогрессию: " + 0);
                }
                else
                {
                    Console.WriteLine("Элементы массива  образуют арифметическую прогрессию: " + d);
                }
                Console.ReadLine();
            }
        }
    }
}
