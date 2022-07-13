using System;

namespace _4._1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Random r = new Random();
            
            int sum = 0;   

            Console.WriteLine("введите число строк: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("введите число строк: ");
            int y = int.Parse(Console.ReadLine());

            var A = new int[x, y];                   

            Console.WriteLine("Исходная матрица:");

           

            for (int i = 0; i <x; i++)
            {

                for (int j = 0; j < y; j++)
                {
                    A[i, j] = r.Next(5);
                    Console.Write($"{A[i, j]} ");
                    sum += A[i, j];

                }
               Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех чисел: {sum}");



        }
    }
}
