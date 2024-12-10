using Tyuiu.AkhtarievaNR.Sprint6.Task1.V18.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            double[] wait = { };
            var res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}