using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TodikovDE.Sprint5.Task5.V4.Lib
{
    public class DataService : ISprint5Task5V4
    {
        public double LoadFromDataFile(string path)
        {
            double mult = 1;

            string str = File.ReadAllText(path);
            string[] chisla = str.Split(' ');

            for (int i = 0; i < chisla.Length; i++)
            {
                chisla[i] = chisla[i].Replace(".", ",");

                double temp = Math.Round(Convert.ToDouble(chisla[i]), 3);
                if (temp % 1 == 0) mult *= temp;
            }

            return mult;
        }
    }
}
