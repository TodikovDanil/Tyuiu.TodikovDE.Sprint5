using System.IO;
using Tyuiu.TodikovDE.Sprint5.Task7.V5.Lib;
namespace Tyuiu.TodikovDE.Sprint5.Task7.V5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Тодиков Д. Э. | ИСТНб-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спритн #5                                                              *");
            Console.WriteLine("* Тема: Создания итогого решения по спринту                              *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #5                                                             *");
            Console.WriteLine("* Выполнил: Тодиков Даниил Эдуардович | ИСТНб-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            DataService ds = new DataService();
            string path = @"C:\Users\User\source\repos\Tyuiu.TodikovDE.Sprint5\DataSprint5\InPutDataFileTask7V5.txt";
            string pathSaveFile = @"C:\Users\User\source\repos\Tyuiu.TodikovDE.Sprint5\DataSprint5\InPutDataFileTask7V5.txt";

            Console.WriteLine("Данные находятся в файле: " + path);



            Console.WriteLine(" ***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile.Replace("   ",""));

            Console.ReadKey();
        }
    }
}