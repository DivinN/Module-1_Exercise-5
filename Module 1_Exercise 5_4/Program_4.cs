using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_5_4
{
    class Program_4
    {
        static void Main(string[] args)
        {
            int arrayLen = 20;
            int[] array = new int[arrayLen];
            Random random = new Random();

            for (int i = 0; i < arrayLen; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            int num = 0;

            for (int i = 1; i < arrayLen; i+=2)
            {
                if ((array[i] % 2) != 0 && array[i] > 0)
                {
                    num++;
                    Console.WriteLine("Нечетное положительное число: {0}", array[i]);
                }
            }

            Console.WriteLine("Массив содержит {0} элементов. Нечетных положительных на четных местах: {1}.", arrayLen, num);
            Console.ReadKey();

        }
    }
}
