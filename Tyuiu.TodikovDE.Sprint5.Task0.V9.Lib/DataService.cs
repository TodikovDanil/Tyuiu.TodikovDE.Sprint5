using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.TodikovDE.Sprint5.Task0.V9.Lib
{
    public class DataService : ISprint5Task0V9
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutputFileTask0.txt";

            double z = Math.Pow(x, 3) / (Math.Pow(x, 2) - 1);
            z = Math.Round(z,3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
