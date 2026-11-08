using Tyuiu.TsarevMA.Sprint4.Task5.V18.Lib;
namespace Tyuiu.TsarevMA.Sprint4.Task5.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[,] {
                { -1, 2, -3, 4, -5 },
                { 6, -7, 1, 2, -3 },
                { 4, 5, -6, 7, -1 },
                { 2, -3, 4, -5, 6 },
                { -2, 1, -2, 1, -2 }
            };

            int[,] res = ds.Calculate(matrix);

            bool resAllPositiveOrZero = true;
            int rows = res.GetUpperBound(0) + 1;
            int cols = res.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (res[i, j] < 0)
                    {
                        resAllPositiveOrZero = false;
                    }
                }
            }

            Assert.IsTrue(resAllPositiveOrZero);
        }
    }
}
