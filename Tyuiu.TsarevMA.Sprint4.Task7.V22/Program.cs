using Tyuiu.TsarevMA.Sprint4.Task7.V22.Lib;
namespace Tyuiu.TsarevMA.Sprint4.Task7.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            string value = "695324951753684";

            Console.Title = "Спринт #4 | Выполнил: Царев М. А. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Царев М. А. | СМАРТб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"695324951753684\". Преобразуйте ее     *");
            Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Строка: " + value);
            Console.WriteLine("Размер матрицы: {0}x{1}", n, m);

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

            Console.WriteLine("\nМатрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, value);

            Console.WriteLine("Произведение четных чисел = " + res);

            Console.ReadKey();
        }
    }
}