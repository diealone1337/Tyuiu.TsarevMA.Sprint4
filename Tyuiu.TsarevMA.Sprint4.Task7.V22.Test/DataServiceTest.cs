using Tyuiu.TsarevMA.Sprint4.Task7.V22.Lib;
namespace Tyuiu.TsarevMA.Sprint4.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 5;
            int m = 3;
            string value = "695324951753684";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, value);
            int wait = 9216;

            Assert.AreEqual(wait, res);
        }
    }
}
