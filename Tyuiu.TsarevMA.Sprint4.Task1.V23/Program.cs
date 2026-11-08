using Tyuiu.TsarevMA.Sprint4.Task1.V23.Lib;
namespace Tyuiu.TsarevMA.Sprint4.Task1.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Царев М. А. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Царев М. А. | СМАРТб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 17 элементов, заполненный          *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 9. Подсчитать сумму           *");
            Console.WriteLine("* четных элементов массива. С клавиатуры: 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6,  *");
            Console.WriteLine("* 8, 7, 5, 9, 9, 9                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[] { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9 };

            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Сумма четных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}
