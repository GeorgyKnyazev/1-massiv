using System;

namespace _1_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = 
            { 
                { 1, 2 }, 
                { 3, 4 } 
            };
            int sumOfSecondline;
            int productOfFirstColumn;

            sumOfSecondline = array[1,0] + array[1,1];
            productOfFirstColumn = array[0,0] * array[1,0];

            Console.WriteLine("Сумма второй строки равна: " + sumOfSecondline);
            Console.WriteLine("Произведение первого столбца равно: " + productOfFirstColumn);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] +" | ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine("Hello World!");
        }
    }
}
