using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task1.V18.Lib
{
    public class DataService : ISprint6Task1V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mas;
            int len = stopValue - startValue + 1;
            mas = new double[len];
            double res;
            int j = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                res = Math.Round((((2 * Math.Sin(i)) / (3 * i + 1.2)) + (Math.Cos(i)) - ((7 * i) * 2)),2);
                mas[j] = (double)res;
                j++;
            }
            return mas;
        }
    }
}
