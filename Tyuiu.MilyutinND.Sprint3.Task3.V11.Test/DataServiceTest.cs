using Tyuiu.MilyutinND.Sprint3.Task3.V11.Lib;

namespace Tyuiu.MilyutinND.Sprint3.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            string value = "qpddd.q";

            DataService ds = new DataService();
            string res = ds.ReplaceCharOnNum(value, 'q', '7');
            Assert.AreEqual("7pddd.7", res);
        }
    }
}