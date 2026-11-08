using Tyuiu.TsarevMA.Sprint4.Task3.V8.Lib;
namespace Tyuiu.TsarevMA.Sprint4.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Царев М. А. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Царев М. А. | СМАРТб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный          *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 8. Найдите минимальный        *");
            Console.WriteLine("* элемент в четвертом столбце массива.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[,] {
                { 4, 8, 3, 4, 8 },
                { 5, 3, 5, 7, 8 },
                { 3, 7, 2, 7, 7 },
                { 5, 2, 4, 6, 4 },
                { 4, 4, 6, 7, 2 }
            };

            int rows = array.GetUpperBound(0) + 1;
            int cols = array.GetUpperBound(1) + 1;

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Минимальный элемент в четвертом столбце = " + res);

            Console.ReadKey();
        }
    }
}
