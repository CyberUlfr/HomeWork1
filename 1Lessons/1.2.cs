using System;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь состоящий из 10 символов сторон света (Ю,С,З,В):");
            int x = 0, y = 0;
            for (int a = 0; a < 10; a++)
            {
                char input = Convert.ToChar(Console.Read());
                Console.Clear();
                switch (input)
                {
                    case 'с':
                    case 'С':
                        x++;
                        break;
                    case 'з':
                    case 'З':
                        y++;
                        break;
                    case 'в':
                    case 'В':
                        y--;
                        break;
                    case 'ю':
                    case 'Ю':
                        x--;
                        break;
                    default:
                        Console.WriteLine("Неправильно введены данные");
                        break;
                }
            }
            double result = Math.Sqrt((x * x) + (y * y));
            Console.WriteLine($"Растояние между начальной и конченой точкой: {result}");
            Console.ReadKey();
        }
    }
}
