using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TsarevMA.Sprint4.Task7.V22.Lib
{
    public class DataService : ISprint4Task7V22
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            int prod = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        prod *= mtrx[i, j];
                    }
                }
            }
            return prod;
        }
    }
}
