using System;
using System.Collections.Generic;

namespace _1._2
{
    class Program
    {
        static public string[] MenuStrings =
        {
             "1 - Вывод списка",
             "2 - Добавление нового формата",
             "3 - Удаление формата по короткому описанию",
             "4 - Поиск формата по короткому описанию",
             "5 - Выход",
        };
        static public void PrintMenu()
        {
            Console.Clear();
            foreach (var menuString in MenuStrings)
            {
                Console.WriteLine(menuString);
            }
            Console.WriteLine("Нажмите цифру, соотсвтующию номеру меню.");
        }
        static public void PrintList(Dictionary<string, string> format)
        {
            Console.Clear();
            if (format.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else 
            {
                foreach (KeyValuePair<string, string> elem in format)
                {
                    Console.WriteLine("Короткое описание = {0}, Полное описание = {1}", elem.Key, elem.Value);
                }
            }    
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void GetElem(Dictionary<string, string> format)
        {
            Console.Clear();
            Console.Write("Введите короткое описание формата: ");
            string shortDescription = Console.ReadLine();
            while (shortDescription.Trim() == "")
            {
                Console.Write("Попробуйте снова ввести формат: ");
                shortDescription = Console.ReadLine();
            }
            Console.Write("Введите полное описание формата: ");
            string fullDescription = Console.ReadLine();
            if (fullDescription.Trim() == "")
            {
                Console.Write("Попробуйте снова ввести формат: ");
                fullDescription = Console.ReadLine();
            }
            else 
            {
                format.Add(shortDescription, fullDescription);
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void RemoveElem(Dictionary<string, string> format)
        {
            Console.Clear();
            Console.Write("Введите короткое описание формата который хотите удалить: ");
            string shortDescription = Console.ReadLine();
            if (shortDescription.Trim() != "")
            {
                if (format.Remove(shortDescription)) 
                {
                    Console.Write("Формат удалён");
                }
                else 
                {
                    Console.Write("Формат введен неверно");
                }
            }
            else
            {
                Console.WriteLine("Попробуйте снова ввести формат");
            }
            Console.WriteLine();
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void SearchElem(Dictionary<string, string> format)
        {
            Console.Clear();
            Console.Write("Введите короткое описание формата который хотите найти: ");
            string shortDescription = Console.ReadLine();
            if (shortDescription.Trim() != "")
            {
                if (format.ContainsKey(shortDescription))
                {
                    Console.Write(format[shortDescription]);
                }
                else
                {
                    Console.Write("Формат введен неверно");
                }
            }
            else
            {
                Console.WriteLine("Попробуйте снова ввести формат");
            }
            Console.WriteLine();
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> Format = new Dictionary<string, string>();
            Format.Add("png", "portable network graphics");
            Format.Add("txt", "text");
            Format.Add("jpg", "joint photographic experts group");
            Format.Add("gif", "graphics interchange format");
            Format.Add("doc", "document");
            foreach (KeyValuePair<string, string> kvp in Format)
            {
                Console.WriteLine("Короткое описание = {0}, Полное описание = {1}", kvp.Key, kvp.Value);
            }
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMenu();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        PrintList(Format);
                        break;
                    case ConsoleKey.D2:
                        GetElem(Format);
                        break;
                    case ConsoleKey.D3:
                        RemoveElem(Format);
                        break;
                    case ConsoleKey.D4:
                        SearchElem(Format);
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D5);
            Console.WriteLine("Удачи!");
        }
    }
}
