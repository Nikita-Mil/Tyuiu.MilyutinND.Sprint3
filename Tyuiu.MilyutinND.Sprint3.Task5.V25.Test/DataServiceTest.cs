using Tyuiu.MilyutinND.Sprint3.Task5.V25.Lib;

namespace Tyuiu.MilyutinND.Sprint3.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int i = 1;
            int k = 1;
            int x = 2;
            int z = 3;
            int g = 10;

            var res = ds.GetSumSumSeries(x, i, k, z, g);
            double wait = 6133.748;
            Assert.AreEqual(wait, res);
        }
    }
}