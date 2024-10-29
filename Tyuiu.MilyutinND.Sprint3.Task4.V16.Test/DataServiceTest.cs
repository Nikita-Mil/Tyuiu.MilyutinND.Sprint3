using Tyuiu.MilyutinND.Sprint3.Task4.V16.Lib;

namespace Tyuiu.MilyutinND.Sprint3.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 7.354;
            Assert.AreEqual(wait, res);
        }
    }
}