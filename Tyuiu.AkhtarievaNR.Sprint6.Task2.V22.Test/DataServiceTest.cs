using Tyuiu.AkhtarievaNR.Sprint6.Task2.V22.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task2.V22.Test
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
            double[] wait = { 7.76, 7.36, 7.26, 7.90, 15.88, 2, 4.35, 5.63, 6.49, 6.49, 6.32 };
            var res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}