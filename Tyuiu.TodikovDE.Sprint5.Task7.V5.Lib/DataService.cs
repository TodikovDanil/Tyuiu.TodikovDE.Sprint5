using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TodikovDE.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V5.txt");
            string outText = "";
            string alp = "[a-z]";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    outText += Regex.Replace(line, alp, "", RegexOptions.IgnoreCase);
                    outText = outText.Replace("    ", "");
                }
                File.AppendAllText(pathSaveFile, outText);
                return pathSaveFile;
            }
        }
    }
}
