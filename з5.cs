using System;

namespace задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов в массиве:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Введите элементы массива( в массиве должны присутствоват два одинаковых элемента): ");
            for (int i = 0; i < N; i++)
            {
                int c = Convert.ToInt32(Console.ReadLine());
                A[i] = c;
            }
            for (int i = 2; i < N; i++)
            {
                for (int j = 1; j < i - 1; j++)
                {
                    int k = A[i];
                    int l = A[j];
                    if (k == l)
                    {
                        Console.WriteLine("Номера:" +j +"  "+ +i);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
