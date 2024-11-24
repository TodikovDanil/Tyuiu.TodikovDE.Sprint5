using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TodikovDE.Sprint5.Task6.V15.Lib
{
    public class DataService : ISprint5Task6V15
    {
        public int LoadFromDataFile(string path)
        {
            int C = 0;
            using (StreamReader R = new(path))
            {
                string L;
                while ((L = R.ReadLine()) != null)
                {
                    for (int i = 0; i < L.Length; i++)
                    {
                        if (L[i] >= 'А' && L[i] <= 'я')
                        {
                            if ((L[i + 1] == ' ') || (L[i + 1] == '.') || (L[i + 1] == ','))
                            {
                                C++;
                            }
                        }
                    }
                }
                return C;
            }
        }
    }
}

