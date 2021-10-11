using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_5_6
{
    class Program_6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число N. Алгоритм сформирует массив NxN.");
            int N = Convert.ToInt32(Console.ReadLine());

            // Создаем и заполняем двумерный массив
            int[,] block = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine("Введите число.");
                    block[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            // Показываем, что за массив получился
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0, 3} ", block[i, j]);
                }
                Console.WriteLine();
            }
            
            // Получим сумму первой строки, с которой будем сравнивать остальные
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += block[0, i];
            }
            Console.WriteLine("Сумма первой строки: {0, 3} ", sum);

            bool flag = false;
            // Проверка строк, начиная со второй
            for (int i = 1; i < N; i++)
            {
                int sumTemp = 0;
                for (int j = 0; j < N; j++)
                {
                    sumTemp += block[i, j];
                }
                if (sum == sumTemp)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    Console.WriteLine("Не прошло по {0} строке.", i + 1);
                    break;
                }
            }
            
            // Проверка столбцов
            if (flag == true)
            {
                for (int i = 0; i < N; i++)
                {
                    int sumTemp = 0;
                    for (int j = 0; j < N; j++)
                    {
                        sumTemp += block[j, i];
                    }
                    if (sum == sumTemp)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        Console.WriteLine("Не прошло по {0} столбцу.", i + 1);
                        break;
                    }
                }
            }

            // Проверка по главной диагонали
            if (flag == true)
            {
                int sumTemp = 0;
                for (int i = 0; i < N; i++)
                {
                    sumTemp += block[i, i];
                }
                  
                if (sum == sumTemp)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    Console.WriteLine("Не прошло по главной диагонали.");
                }
            }
            
            // Проверка по побочной диагонали
            if (flag == true)
            {
                int sumTemp = 0;
                for (int i = 0; i < N; i++)
                {
                    sumTemp += block[i, N - i - 1];
                }

                if (sum == sumTemp)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    Console.WriteLine("Не прошло по побочной диагонали.");
                }
            }
            if (flag == true)
            {
                Console.WriteLine("О чудо! Похоже, что это магический квадрат!");
            }
            Console.ReadKey();

        }
    }
}
