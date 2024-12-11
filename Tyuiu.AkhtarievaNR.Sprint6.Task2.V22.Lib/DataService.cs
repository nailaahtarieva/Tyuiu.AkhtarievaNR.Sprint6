using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task2.V22.Lib
{
    public class DataService : ISprint6Task2V22
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
                res = Math.Round((((2 * i - 3)/(Math.Cos(i) + i)) + 5), 2);
                mas[j] = (double)res;
                j++;
            }
            return mas;
        }
    }
}
