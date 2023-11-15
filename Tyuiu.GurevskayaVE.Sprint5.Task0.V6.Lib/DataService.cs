using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.GurevskayaVE.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double res = x/(Math.Sqrt(Math.Pow(x,2)+x));
            res = Math.Round(res,3);
            File.WriteAllText(path, Convert.ToString(res));
            return path;
        }
    }
}
