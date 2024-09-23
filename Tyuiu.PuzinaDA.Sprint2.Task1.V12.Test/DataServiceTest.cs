using Tyuiu.PuzinaDA.Sprint2.Task1.V12.Lib;
namespace Tyuiu.PuzinaDA.Sprint2.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            int a = 152, b = 116, c = 887, d = 556;
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] {true, true, true, false, true, false};
            CollectionAssert.AreEqual(res, wait);
        }
    }
}