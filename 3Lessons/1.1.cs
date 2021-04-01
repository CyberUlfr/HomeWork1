using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время работы почты");
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите колличество поситителей");
            int visitors = int.Parse(Console.ReadLine());
            Queue<int> workTime = new Queue<int>();
            for (int i = 0; i < visitors; i++)
            {
                Console.WriteLine($"Введите время для обслуживания {i+1} посетителя");
                int timeService = int.Parse(Console.ReadLine());
                workTime.Enqueue(timeService);    
            }
            do
            {
                time = time - workTime.Dequeue();
                if (workTime.Count == 0)
                {
                    break;
                }
            }
            while (time > 0);
            switch (workTime.Count)
            {
                case 0:
                    Console.WriteLine("Все поситители получили плсылку");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine($"Посетителей ушло без посылки {workTime.Count}");
                    Console.ReadKey();
                    break;
            }
            Console.ReadKey();
        }
    }
}
