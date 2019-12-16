using System;

namespace лаб.раб__14
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
            Console.WriteLine("Введите число К:");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число L:");
            int L = Convert.ToInt32(Console.ReadLine());
            int S = 0;
            int k = 0;
            for (int i = K; i<=L; i++)
            {
                S += A[i];
                k = k + 1;
            }
            float SR = S / k;
            Console.WriteLine("Среднее арифметическое элементов массива с номерами от K до L: " + SR);
            Console.ReadLine();
        }
    }
}
