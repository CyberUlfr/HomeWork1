using System;
using System.Collections.Generic;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время работы почты");
            int time = int.Parse(Console.ReadLine());
            if (time <= 0)
            {
                Console.WriteLine("Почта не будет работать, если время работы равно нулю или меньше. Нажмите любую кнопку чтобы закрыть программу.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Введите колличество поситителей");
                int visitors = int.Parse(Console.ReadLine());
                if (visitors <= 0)
                {
                    Console.WriteLine("Посетители не пришли, почта не работала. Нажмите любую кнопку чтобы закрыть программу.");
                    Console.ReadKey();
                }
                else
                {
                    Queue<int> workTime = new Queue<int>();
                    for (int i = 0; i < visitors; i++)
                    {
                        Console.WriteLine($"Введите время для обслуживания {i + 1} посетителя");
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
                            Console.WriteLine("Все поситители получили плсылку. Нажмите любую кнопку чтобы закрыть программу.");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine($"Посетителей ушло без посылки: {workTime.Count}. Нажмите любую кнопку чтобы закрыть программу.");
                            Console.ReadKey();
                            break;
                    }
                }

            }
        }
    }
}
