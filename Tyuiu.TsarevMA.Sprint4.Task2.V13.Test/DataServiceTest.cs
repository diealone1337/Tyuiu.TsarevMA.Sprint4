using Tyuiu.TsarevMA.Sprint4.Task2.V13.Lib;
namespace Tyuiu.TsarevMA.Sprint4.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            int res = ds.Calculate(array);
            int wait = 8192; 

            Assert.AreEqual(wait, res);
        }
    }
}
