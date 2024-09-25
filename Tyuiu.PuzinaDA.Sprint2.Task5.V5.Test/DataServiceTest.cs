using Tyuiu.PuzinaDA.Sprint2.Task5.V5.Lib;
namespace Tyuiu.PuzinaDA.Sprint2.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedCard()
        {
            DataService ds = new DataService();
            int value = 10;
            var res = ds.FindCardValue(value);
            string wait = "Такой карты нет";
            Assert.AreEqual(res, wait);
        }
    }
}