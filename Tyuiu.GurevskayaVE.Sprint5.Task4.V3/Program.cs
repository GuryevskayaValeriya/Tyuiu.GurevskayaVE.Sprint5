using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GurevskayaVE.Sprint5.Task4.V3.Lib;

namespace Tyuiu.GurevskayaVE.Sprint5.Task4.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Гурьевская В.Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Гурьевская В.Е. | ПКТб-23-2                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С: DataSprint5 InPutDataFileTask4V0.txt (файл взять из архива  *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С: DataSprint5  и      *");
            Console.WriteLine("* скопировать в неё файл) в котором есть вещественное значение. Прочитать *");
            Console.WriteLine("*значение из файла и подставить вместо Х в формуле . Вычислить значение   *");
            Console.WriteLine("* по формуле (Полученное значение округлить до трёх знаков после запятой) *");
            Console.WriteLine("* и вернуть полученный результат на консоль.                              *");
            Console.WriteLine("*                                                                         *");  
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string path = $@"C:\DataSprint5\InPutDataFileTask4V3.txt";

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Результат: " + res);
            

            Console.ReadKey();
        }
    }
}
