using Tyuiu.TodikovDE.Sprint5.Task2.V30.Lib;
namespace Tyuiu.TodikovDE.Sprint5.Task2.V30
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Тодиков Д. Э. | ИСТНб-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спритн #5                                                              *");
            Console.WriteLine("* Тема: Создания итогого решения по спринту                              *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #30                                                            *");
            Console.WriteLine("* Выполнил: Тодиков Даниил Эдуардович | ИСТНб-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            DataService ds = new DataService();
            int[,] mtrx = new int[3, 3] { { 3, -1, -3 },
                                         {-2, -5, 0 },
                                         { -8, -7, 2 }};
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]}\t");
                }
                Console.WriteLine();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                string res = ds.SaveToFileTextData(mtrx);

                Console.WriteLine("Файл: " + res);
                Console.WriteLine("Создан!");
                Console.ReadKey();
            }
        }
    }
}