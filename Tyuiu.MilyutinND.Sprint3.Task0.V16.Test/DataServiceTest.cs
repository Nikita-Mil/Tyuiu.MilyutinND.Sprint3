using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using NuGet.Frameworks;
using Tyuiu.MilyutinND.Sprint3.Task0.V16.Lib;

namespace Tyuiu.MilyutinND.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 6;

            double res = ds.GetMultiplySeries(startValue, stopValue, value);

            double wait = 0;

            Assert.AreEqual(wait, res);

        }
    }
}