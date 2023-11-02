using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SafronovVV.Sprint4.Task0.V18.Lib;

namespace Tyuiu.SafronovVV.Sprint4.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Сафронов В. В. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Сафронов Владислав Валерьевич | АСОиУб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, выводящую сумму нечетных чисел массива из 10 эл-тов,*");
            Console.WriteLine("* включающих в себя числа от 0 до 9.                                      *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            Console.WriteLine("Исходный массив: " + "[{0}]", string.Join(", ", array));



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма нечетных элементов массива = " + ds.GetSumOddArrEl(array));

            Console.ReadKey();
        }
    }
}
