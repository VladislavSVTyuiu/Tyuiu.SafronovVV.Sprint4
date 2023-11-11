using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SafronovVV.Sprint4.Task7.V19.Lib;

namespace Tyuiu.SafronovVV.Sprint4.Task7.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил: Сафронов В.В | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Сафронов Владислав Валерьевич  |  АСОиУб-23-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 90817264. Преобразуйте ее в матрицу   *");
            Console.WriteLine("* 4 на 2 и подсчитайте количество нечетных чисел в матрице.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int n = 4;
            int m = 2;
            string text = "90817264";
            Console.WriteLine("n: " + n);
            Console.WriteLine("m: " + m);
            Console.WriteLine("String: " + text);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(n, m, text);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
