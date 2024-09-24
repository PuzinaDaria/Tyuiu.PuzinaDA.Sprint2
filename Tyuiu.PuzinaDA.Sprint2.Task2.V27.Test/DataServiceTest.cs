using Tyuiu.PuzinaDA.Sprint2.Task2.V27.Lib;
namespace Tyuiu.PuzinaDA.Sprint2.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedDot()
        {
            DataService ds = new DataService();
            int x = 4, y = 11;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }
    }
}