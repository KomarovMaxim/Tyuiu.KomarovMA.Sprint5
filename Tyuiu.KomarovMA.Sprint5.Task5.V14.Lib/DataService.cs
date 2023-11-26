using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KomarovMA.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            double maxNum = double.MinValue;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double number = Convert.ToDouble(line);
                    if (number % 3 == 0 && number > maxNum)
                    {
                        maxNum = number;
                    }
                }
            }

            double factorial = 1;
            for (int i = 1; i <= maxNum; i++)
            {
                factorial *= i;
            }

            return Math.Round(factorial, 3);
        }
    }
}