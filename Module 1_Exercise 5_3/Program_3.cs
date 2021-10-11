using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_5_3
{
    class Program_3
    {
        static void Main(string[] args)
        {
            // Создание массива
            int arrayLen = 10;
            int[] array = new int[arrayLen];
            Random random = new Random();

            for (int i = 0; i < arrayLen; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0, 3} ", array[i]);
            }
            // Упорядочивание по возрастанию первой части
            for (int i = 0; i < arrayLen - 6; i++)
            {
                for (int j = i+1; j < arrayLen - 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            // Упорядочивание по убыванию левой части
            for (int i = 5; i < arrayLen - 1; i++)
            {
                for (int j = i + 1; j < arrayLen; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < arrayLen; i++)
            {
                Console.Write("{0, 3} ", array[i]);
            }
            
            Console.ReadKey();
        }
    }
}
