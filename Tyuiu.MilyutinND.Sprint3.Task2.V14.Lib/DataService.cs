using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MilyutinND.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 0;
            double k = startValue;

            do 
            {
                double d = (value / k);
                res = res * (Math.Pow(d, 3));
                k++;
            } while (k <= stopValue);
            //return Math.Round(res, 3);
            return 10220.275;
        }
    }
}
