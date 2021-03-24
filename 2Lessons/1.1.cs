using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args) // O(n) — линейная сложность
        {
            Console.WriteLine("Введите размер массива:");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            Console.Clear();
            Console.WriteLine($"Размер массива:{arraySize}");
            for (int nums = 0; nums < arraySize; ++nums) 
            {
                Console.WriteLine($"Введите элемент массива {nums+1}");
                array[nums] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.Write("Отсортированные элементы массива:");
            for (int nums = 0; nums < arraySize; ++nums)
            {
                Array.Sort(array);
                Console.Write(array[nums]);
            }
            Console.WriteLine();
            Console.WriteLine($"Количество различных чисел в массиве:{array.Distinct().Count()}");
            Console.ReadKey();
        }
    }
}
