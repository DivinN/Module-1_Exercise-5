using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_5_2
{
    class Program_2
    {
        static void Main(string[] args)
        {
            int arrayLen = 15;
            int[] array = new int[arrayLen];
            Random random = new Random();

            for (int i = 0; i < arrayLen; i++)
            {
                array[i] = random.Next(0,50);
                Console.Write("{0} ", array[i]);
            }

            int max = array[0];
            int min = array[0];
            
            for (int i = 0; i < arrayLen; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine("Массив содержит {0} элементов. Максимальное: {1}, минимальное: {2}, их сумма: {3}", arrayLen, max, min, min + max);
            Console.ReadKey();

        }
    }
}
