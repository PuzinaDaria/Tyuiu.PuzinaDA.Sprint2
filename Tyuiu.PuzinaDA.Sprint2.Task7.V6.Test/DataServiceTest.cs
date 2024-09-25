using Tyuiu.PuzinaDA.Sprint2.Task7.V6.Lib;
namespace Tyuiu.PuzinaDA.Sprint2.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedDot()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            Assert.IsTrue(ds.CheckDotInShadedArea(x, y));
        }
    }
}