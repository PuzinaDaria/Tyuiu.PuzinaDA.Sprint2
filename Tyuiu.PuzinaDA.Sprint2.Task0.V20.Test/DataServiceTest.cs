using Tyuiu.PuzinaDA.Sprint2.Task0.V20.Lib;
namespace Tyuiu.PuzinaDA.Sprint2.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            int x = 1075, y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] {true, false, true, false, true, false};
            CollectionAssert.AreEqual(res, wait);
        }
    }
}