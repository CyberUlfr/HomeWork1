using System;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца:");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
                Console.WriteLine("Январь");
            if (n == 2)
                Console.WriteLine("Февраль");
            if (n == 3)
                Console.WriteLine("Март");
            if (n == 4)
                Console.WriteLine("Апрель");
            if (n == 5)
                Console.WriteLine("Май");
            if (n == 6)
                Console.WriteLine("Июнь");
            if (n == 7)
                Console.WriteLine("Июль");
            if (n == 8)
                Console.WriteLine("Август");
            if (n == 9)
                Console.WriteLine("Сентябрь");
            if (n == 10)
                Console.WriteLine("Октябрь");
            if (n == 11)
                Console.WriteLine("Ноябрь");
            if (n == 12)
                Console.WriteLine("Декабрь");
            if (n < 1 || n > 12)
                Console.WriteLine("Неправильный номер, введите от 1 до 12");
            Console.ReadKey();
        }
    }
}

