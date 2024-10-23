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
            int startValue = 5;
            int stopValue = 3;

            double res = ds.GetMultiplySeries(startValue, stopValue, value);

            double wait = 1;

            Assert.AreEqual(wait, res);

        }
    }
}