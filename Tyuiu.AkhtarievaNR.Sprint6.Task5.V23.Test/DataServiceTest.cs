using System.IO;
using Tyuiu.AkhtarievaNR.Sprint6.Task5.V23.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V23.txt";
            var res = ds.LoadFromDataFile(path);
            double[] mass = { -17, -14.32, -7.84, -1.57, -3.64, -13.26, -8.91, -17.77, -9, -1.49, -7 };
            CollectionAssert.AreEqual(mass, res);
        }
    }
}