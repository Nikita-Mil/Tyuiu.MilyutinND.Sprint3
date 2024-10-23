﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MilyutinND.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            int i;

            for (i = startValue; i <= stopValue; i++)

            {
                sumSeries = sumSeries * (Math.Pow(value / i, 3));
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
