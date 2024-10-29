using Tyuiu.MilyutinND.Sprint3.Task2.V14.Lib;

namespace Tyuiu.MilyutinND.Sprint3.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 12;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 0;

            Assert.AreEqual(wait, res);
        }
    }
}