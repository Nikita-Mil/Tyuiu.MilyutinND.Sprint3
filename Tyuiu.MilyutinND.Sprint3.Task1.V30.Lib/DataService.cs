using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MilyutinND.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            //sumseries
            double sumSeries = 0;
            while (startValue <= stopValue)

            {
                sumSeries = sumSeries + ((Math.Pow(stopValue, value) + (5 / (value + 4))) * Math.Sin(stopValue));
                startValue++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
