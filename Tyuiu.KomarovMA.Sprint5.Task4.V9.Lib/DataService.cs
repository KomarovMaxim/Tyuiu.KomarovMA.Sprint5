using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KomarovMA.Sprint5.Task4.V9.Lib
{
    public class DataService : ISprint5Task4V9
    {
        public double LoadFromDataFile(string path)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            double y = 0;

            string x = File.ReadAllText(path);
            Console.WriteLine(Convert.ToDouble(x));
            y = 1 / (Math.Sin(Convert.ToDouble(x))) + Math.Pow(Convert.ToDouble(x), 2);
            return Math.Round(y, 3);
        }
    }
}