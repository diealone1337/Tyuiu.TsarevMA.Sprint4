using Tyuiu.TsarevMA.Sprint4.Task0.V25.Lib;
namespace Tyuiu.TsarevMA.Sprint4.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] array = new int[] { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            int res = ds.GetSumEvenArrEl(array);
            int wait = 42;

            Assert.AreEqual(wait, res);
        }
    }
}