using Tyuiu.BurmistrovNS.Sprint2.Task4.V15.Lib;

namespace Tyuiu.BurmistrovNS.Sprint2.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 3.08;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1600;
            double res = ds.Calculate(x, y);
            double wait = 11.402;
            Assert.AreEqual(wait, res);
        }
    }
}
