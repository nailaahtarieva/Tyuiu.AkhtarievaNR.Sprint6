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
            double[] wait = { 70.14, 55.21, 41.05, 27.96, 15.48, 1.0, -13.06, -28.16, -42.96, -56.77, -69.83 };
            var res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}