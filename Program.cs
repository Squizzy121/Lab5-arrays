using System;

namespace Zadacha5._1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість елементів массиву");
            int n = int.Parse(Console.ReadLine());
            CreateNewArray(n);
            Console.ReadKey();
        }
        static void CreateNewArray(int n)
        {
            int max = int.MinValue;
            int IndexOfMax=-1;
            int[] array = new int[n];
            /*for(int i=0;i<n;i++)
             * {
             * int num=int.Parse(Console.ReadLine());
             * array[i]=num;
             * if (num>=max)
             *   {
             *   max=num;
             *   IndexOfMax=i;
             *   }
             * }
             */
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-101,101);
                if (array[i] >= max)
                {
                    max = array[i];
                    IndexOfMax = i;
                }
            }
            PrintArray(array, n);
            MultiplyNumbersInArray(array, IndexOfMax);

        }
        static void PrintArray(int[] array, int n)
        {
            Console.WriteLine("Перелік елементів массиву");
            for (int k = 0; k < n; k++)
            {
                Console.Write("{0} ", array[k]);
            }
        }
        static void MultiplyNumbersInArray(int[] array, int IndexOfMax)
        {
            double multiply = 1;
            for (int q = 0; q < IndexOfMax; q++)
            {
                    multiply *= array[q];
            }
            Console.WriteLine("\nДобуток чисел перед останнім входженням максимального числа дорівнює {0}", multiply);
        }

    }
}
