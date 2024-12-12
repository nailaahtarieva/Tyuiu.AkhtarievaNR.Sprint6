using Tyuiu.AkhtarievaNR.Sprint6.Task4.V13.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = -5;
            int z = 5;
            double[] d = { -9.10, 1.55, 292,78, -0.57, -0.35, 2.00, 4.35, 4.57, -288.78, 2.45, 13.10 };
            var res = ds.GetMassFunction(a, z);
            CollectionAssert.AreEqual(res, d);
        }
    }
}