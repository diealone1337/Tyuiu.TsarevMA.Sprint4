using Tyuiu.TsarevMA.Sprint4.Task0.V25.Lib;
namespace Tyuiu.TsarevMA.Sprint4.Task1.V25
{
    class Program
    {
        static void Main(string[] args)   
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Царев М. А. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Царев М. А. | СМАРТб-26-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный          *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать сумму           *");
            Console.WriteLine("* четных элементов массива.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[] { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };

            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetSumEvenArrEl(array);

            Console.WriteLine("Сумма четных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}