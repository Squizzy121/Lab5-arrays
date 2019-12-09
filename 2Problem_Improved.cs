using System;

namespace Zadacha5._1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть в строку число, яким методом ви хочете вводити числа в массив:\nРандомними числами(Введіть 1)\nВручну(Введіть 2)");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість елементів массиву");
            int n = int.Parse(Console.ReadLine());
            int[] array;
            if (choice == 1)
            {
                array = FillingNewArrayWithRandomNumbers(n);
            }
            else
            {
                array = FillingNewArrayWithNumbersFromKeyboard(n);
            }
            PrintArray(array,n);
            double multiplication= MultiplyNumbersInArray(array, n);
            Console.WriteLine("\nдобуток елементів, які стоять перед останім входженням максимального числа дорівнює: {0}",multiplication);
            Console.ReadKey();
        }
        static int[] FillingNewArrayWithNumbersFromKeyboard(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                array[i] = num;
            }
            return array;
        }
        static int[] FillingNewArrayWithRandomNumbers(int n)
        {
            int[] array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-101, 101);
            }
            return array;
        }
        static void PrintArray(int[] array, int n)
        {
            Console.WriteLine("Перелік елементів массиву:");
            for (int k = 0; k < n; k++)
            {
                Console.Write("{0} ", array[k]);
            }
        }
        static double MultiplyNumbersInArray(int[] array, int n)
        {
            int max = int.MinValue;
            int IndexOfMax = -1;
            double multiplication = 1;
            for (int q = 0; q < n; q++)
            {
                if (array[q] >= max)
                {
                    max = array[q];
                    IndexOfMax = q;
                }
            }
            for (int q = 0; q < IndexOfMax; q++)
            {
                multiplication *= array[q];
            }
            return multiplication;
        }
    }
}
