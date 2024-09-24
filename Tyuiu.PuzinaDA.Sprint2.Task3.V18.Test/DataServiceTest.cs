using Tyuiu.PuzinaDA.Sprint2.Task3.V18.Lib;
namespace Tyuiu.PuzinaDA.Sprint2.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked1()
        {
            DataService ds = new DataService(); 
            double x = 2;
            var res = ds.Calculate(x);
            Assert.AreEqual(36, res);
        }

        [TestMethod]
        public void Checked2()
        {
            DataService ds = new DataService();
            double x = 0;
            var res = ds.Calculate(x);
            Assert.AreEqual(0.75, res);
        }

        [TestMethod]
        public void Checked3()
        {
            DataService ds = new DataService();
            double x = 1;
            var res = ds.Calculate(x);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void Checked4()
        {
            DataService ds = new DataService();
            double x = -24;
            var res = ds.Calculate(x);
            Assert.AreEqual(-263.958, res);
        }
    }
}