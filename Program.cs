using System;

namespace _11
{
    class Program
    {
        static int[] FillingNewArrayWithNumbersFromKeyboard(int n)
        {
            int[] array = new int[n];
            for (int q = 0; q <= n - 1; q++)
            {
                int num = int.Parse(Console.ReadLine());
                array[q] = num;
            }
            return array;
        }
        static int[] FillingNewArrayWithRandomNumbers(int n)
        {
            int[] array = new int[n];
            Random rand = new Random();
            foreach (int i in array)
            {
                array[i] = rand.Next(-101, 101);
            }
            return array;
        }
        static void PrintArray(int[] array)
        {
            Console.WriteLine("перелік елементів массиву");
            foreach (int k in array)
            {
                Console.Write("{0} ", k);
            }
        }
        static double MultiplyNumbersInArray(int[] array, int n)
        {
            int max = array[0];
            foreach (int q in array)
            {
                if (q>=max)
                {
                    max = q;
                }
            }
            int IndexOfMax = Array.LastIndexOf(array, max);
            int multiplication = 1;
            for (int q = 0; q < IndexOfMax; q++)
            {
                multiplication *= array[q];
            }
            return multiplication;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть в строку число яким методом ви хочете вводити числа в массив:\nРандомними числами(Введіть 1)\nВручну(Введіть 2)");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість елементів массиву");
            int n = int.Parse(Console.ReadLine());
            int[] array;
            if (choice==1)
            {
                array = FillingNewArrayWithRandomNumbers(n);
            }
            else
            {
                array = FillingNewArrayWithNumbersFromKeyboard(n);
            }
            PrintArray(array);
            double multiplication = MultiplyNumbersInArray(array, n);
            Console.WriteLine("\nДобуток елементів перед останім входженням максимального числа дорівнює: {0}", multiplication);
            Console.ReadKey();
        }
    }
}
