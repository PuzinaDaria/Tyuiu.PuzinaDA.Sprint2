using Tyuiu.PuzinaDA.Sprint2.Task4.V25.Lib;
namespace Tyuiu.PuzinaDA.Sprint2.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedCalculate1()
        {
            DataService ds = new DataService();
            int x, y;
            x = 1;
            y = 8;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(6561, res);

        }
        [TestMethod]
        public void CheckedCalculate2()
        {
            DataService ds = new DataService();
            int x, y;
            x = 1;
            y = -400;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(-400.005, res);

        }
    }
}