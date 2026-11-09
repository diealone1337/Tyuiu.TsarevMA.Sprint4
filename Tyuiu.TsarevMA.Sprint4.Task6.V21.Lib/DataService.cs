using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TsarevMA.Sprint4.Task6.V21.Lib
{
    public class DataService : ISprint4Task6V21
    {
        int count = 0;
        public int Calculate(string[] array)
        {
            foreach (string str in array)
            {
                if (str.Length < 8)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
