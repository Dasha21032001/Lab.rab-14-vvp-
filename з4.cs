using System;

namespace задание_4
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
            int k = 0;
            for (int i = 1; i < N - 1; i++)
            {
                if ((A[i] > A[i + 1]) && (A[i] > A[i - 1]))
                {
                    k = i;
                }
            }
            Console.WriteLine("Номер последнего локального максимума:" + k);
            Console.ReadLine();
        }
    }
}
