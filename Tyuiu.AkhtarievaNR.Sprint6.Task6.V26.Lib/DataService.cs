using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task6.V26.Lib
{
    public class DataService : ISprint6Task6V26
    {
        public string CollectTextFromFile(string str, string path)
        {
            string resstr = "";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] array = line.Split(" ");
                    if (array[0] == "")
                    {
                        break;
                    }
                    Array.Reverse(array);
                    resstr += array[0] + " ";
                }

            }

            return resstr.Trim();



        }
    }
}
