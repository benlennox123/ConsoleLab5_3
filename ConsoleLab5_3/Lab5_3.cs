using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab5_3
{
    class Lab5_3
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            int t = 1;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0,2}-й элемент массива: {1,3}", t++, array[i]);
                Console.WriteLine();
                if (i==4)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сортировка");
    // Возрастание
            for (int i = 0; i < n-6; i++)
            {
                for (int j = i+1; j < n-5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            t = 1;
            for (int i = 0; i < n-5; i++)
            {
                Console.Write("{0,2}-й элемент массива: {1,3}", t++, array[i]);
                Console.WriteLine();
            }
    // Убывание
            for (int i = 5; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            t = 6;
            for (int i = 5; i < n; i++)
            {
                Console.Write("{0,2}-й элемент массива: {1,3}", t++, array[i]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
