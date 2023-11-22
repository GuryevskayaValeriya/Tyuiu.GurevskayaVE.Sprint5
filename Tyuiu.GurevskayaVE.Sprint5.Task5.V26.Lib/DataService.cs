using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GurevskayaVE.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            double pol = 0;
            double otr = 0;
            StreamReader reader = new StreamReader(path);
            string line;

            double dline;
            while ((line = reader.ReadLine()) != null)
            {
                dline = Convert.ToDouble(line);
                if (dline < 0 && dline % 1 != 0)
                    otr += dline;
                if (dline > 0 && dline % 1 != 0)
                    pol += dline;
            }
            return Math.Round(pol + otr, 3);
        }
    }
}
