﻿using Tyuiu.TodikovDE.Sprint5.Task4.V2.Lib;
namespace Tyuiu.TodikovDE.Sprint5.Task4.V2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Тодиков Д. Э. | ИСТНб-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спритн #5                                                              *");
            Console.WriteLine("* Тема: Создания итогого решения по спринту                              *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #2                                                             *");
            Console.WriteLine("* Выполнил: Тодиков Даниил Эдуардович | ИСТНб-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            DataService ds = new DataService();

            string path = @"C:\Users\User\source\repos\Tyuiu.TodikovDE.Sprint5";

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}