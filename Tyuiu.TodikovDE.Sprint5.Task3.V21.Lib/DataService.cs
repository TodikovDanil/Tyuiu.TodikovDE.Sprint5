﻿using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TodikovDE.Sprint5.Task3.V21.Lib
{
    public class DataService : ISprint5Task3V21
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            double y = Math.Round((Math.Pow(x,2) + 1)/(Math.Sqrt(4 * x * x - 3)), 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return path;
        }
    }
}
