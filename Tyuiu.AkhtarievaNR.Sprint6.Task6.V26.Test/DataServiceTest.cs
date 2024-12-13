using Tyuiu.AkhtarievaNR.Sprint6.Task6.V26.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutFileTask6V26.txt";
            string str = File.ReadAllText(path);
            var res = ds.CollectTextFromFile(str,path);
            string wait = "HlidZPHKeLLU OoyPFhjSRwp GUilXww iukCfO UaZNpcgYjw";
            Assert.AreEqual(wait, res);
        }
    }
}