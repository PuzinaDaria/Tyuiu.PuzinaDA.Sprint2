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
            Assert.AreEqual(ds.FindCardValue(6), "шестёрка");
            Assert.AreEqual(ds.FindCardValue(7), "семёрка");
            Assert.AreEqual(ds.FindCardValue(8), "восьмёрка");
            Assert.AreEqual(ds.FindCardValue(9), "девятка");
            Assert.AreEqual(ds.FindCardValue(11), "валет");
            Assert.AreEqual(ds.FindCardValue(12), "дама");
            Assert.AreEqual(ds.FindCardValue(13), "король");
            Assert.AreEqual(ds.FindCardValue(14), "туз");

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardValue(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardValue(10);
            });
        }
    }
}