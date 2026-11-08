using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TsarevMA.Sprint4.Task0.V25.Lib
{
    public class DataService : ISprint4Task0V25
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sum = 0;
            int i = 0;
            while (i < array.Length)
            {
                if (array[i] % 2 == 0)
                {
                    sum = sum + array[i];
                }
                i++;
            }
            return sum;
        }
    }
}