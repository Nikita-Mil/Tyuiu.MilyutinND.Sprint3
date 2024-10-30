using Tyuiu.MilyutinND.Sprint3.Task6.V13.Lib;

namespace Tyuiu.MilyutinND.Sprint3.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 8, stopValue = 17;
            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(117, res);
        }
    }
}