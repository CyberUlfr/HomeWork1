using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args) // O(n2) - квадратичная сложность
        {
            Console.WriteLine("Введите размер массива:");
            int[,] array;
            int arraySize = int.Parse(Console.ReadLine());
            array = new int[arraySize, arraySize];
            Console.Clear();
            int quantity = arraySize * arraySize;
            Console.WriteLine($"Введите {quantity} элементов по очереди");
            for (int row = 0; row < arraySize; ++row)
            {
                for (int column = 0; column < arraySize; ++column)
                {
                    array[row, column] = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
            }
            Console.WriteLine("Вывод матрицы на экран");
            for (int row = 0; row < arraySize; ++row)
            {
                Console.WriteLine();
                for (int column = 0; column < arraySize; ++column)
                {
                    Console.Write(array[row, column] + "\t");
                }
            }
            Console.WriteLine();
            Console.Write("Нажмите любую кнопку чтобы узнать результат");
            Console.ReadKey();
            Console.Clear();
            for (int row = 0; row < arraySize; ++row)
            {
                for (int column = 0; column < arraySize; ++column)
                {
                    if (array[row, column] == array[column, row]) continue;
                    Console.WriteLine();
                    Console.WriteLine("Матрица не симметрична");
                    Console.ReadKey();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Матрица симметрична");
            Console.ReadKey();
        }
    }
}
