using System;

namespace _11
{
    class Program
    {
        static void FillingTheArray(int n)
        {
            int[] array = new int[n];
            int max = int.MinValue;
            /*  Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-101,101);
                if (array[i] >= max)
                {
                    max = array[i];
                }
            }*/
            for (int q = 0; q <= n - 1; q++)
            {
                int num = int.Parse(Console.ReadLine());
                array[q] = num;
                if (num >= max)
                {
                    max = num;
                }
            }
            PrintArray(array);
            MultiplyNumbersInArray(array, max);
        }
        static void PrintArray(int[] array)
        {
            Console.WriteLine("перелік елементів массиву");
            foreach (int k in array)
            {
                Console.Write("{0} ", k);
            }
        }
        static void MultiplyNumbersInArray(int[] array, int max)
        {
            int IndexOfMax = Array.IndexOf(array, max);
            int multiplication = 1;
            for (int q = 0; q < IndexOfMax; q++)
            {
                multiplication *= array[q];
            }
            Console.WriteLine("\nДобуток елементів перед останім входженням максимального числа дорівнює: {0}", multiplication);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість елементів массиву");
            int n = int.Parse(Console.ReadLine());
            FillingTheArray(n);
            Console.ReadKey();
        }
    }
}
