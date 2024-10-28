using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MilyutinND.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            //sumseries
            double sumSeries = 0;
            double k;

            while (startValue <= stopValue)

            {
                k = Convert.ToDouble(startValue);
                sumSeries = sumSeries + ((Math.Pow(value, k) + (5 / (k + 4))) * Math.Sin(value));
                startValue++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
