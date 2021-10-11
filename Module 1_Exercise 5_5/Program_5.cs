using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_5_5
{
    class Program_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число N. Алгоритм сформирует массив NxN.");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] block = new int[N, N];

            int temp = 1;
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    block[i, j] = temp;
                    Console.Write("{0} ", temp);
                    if (temp == 1)
                    {
                        temp--;
                    }
                    else
                    {
                        temp++;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
