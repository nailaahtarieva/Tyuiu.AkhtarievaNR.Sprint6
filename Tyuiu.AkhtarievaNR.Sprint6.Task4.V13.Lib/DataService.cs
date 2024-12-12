using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AkhtarievaNR.Sprint6.Task4.V13.Lib
{
    public class DataService : ISprint6Task4V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mas;
            int len = stopValue - startValue + 1;
            mas = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = (3*i) + 2 - ((2*i - i)/(Math.Cos(i))+1);
                mas[count] = Math.Round(y, 2);
                count++;
            }
            return mas;
        }
    }
}
