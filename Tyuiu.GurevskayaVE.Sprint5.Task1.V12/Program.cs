using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GurevskayaVE.Sprint5.Task1.V12.Lib;

namespace Tyuiu.GurevskayaVE.Sprint5.Task1.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Гурьевская В.Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Гурьевская В.Е. | ПКТб-23-2                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция f(x) = ((5x+2,5)/(sin(x)-2))+2 (произвести табулирование)  *");
            Console.WriteLine("* на заданном диапазоне [-5;5] с шагом 1. Произвести проверку деления     *");
            Console.WriteLine("* на ноль. При делении на 0 вернуть 0. Результат сохранить в текстовый    *");
            Console.WriteLine("* файл OutPutFileTask1.txt и вывести на консоль в таблицу. Округлить      *");
            Console.WriteLine("* до двух знаков.                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");


            Console.ReadKey();
        }
    }
}
