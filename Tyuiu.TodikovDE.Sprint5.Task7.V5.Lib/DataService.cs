using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TodikovDE.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            string strLine = "";
            using (StreamReader R = new(path))
            {
                string pathSaveFile = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V5.txt");

                FileInfo fileInfo = new FileInfo(pathSaveFile);
                bool fileExists = fileInfo.Exists;

                if (fileExists)
                {
                    File.Delete(pathSaveFile);
                }
                string fileContent = File.ReadAllText(path);

                string modifiedContent = fileContent.Replace("qwertyuiopasdfghjklzxcvbnm", "");

                File.WriteAllText(pathSaveFile, modifiedContent);
                return pathSaveFile;
            }
        }
    }
}
