using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_5
{
    class Program_1
    {
        static void Main(string[] args)
        {
            int arrayLen = 7;
            int[] array = new int[arrayLen];
            Console.WriteLine("Массив содержит {0} элементов. Заполните его.", arrayLen);

            float sum = 0;
            for (int i = 0; i < arrayLen; i++)
            {
                Console.WriteLine("Введите число");
                int num = Convert.ToInt32(Console.ReadLine());
                array[i] = num;
                sum += num;
            }
            Console.WriteLine("Среднее арифметическое элементов: {0}.", sum / arrayLen);
            Console.ReadKey();
        }
    }
}
