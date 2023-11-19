using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KomarovMA.Sprint5.Task0.V10.Lib
{
    public class DataService : ISprint5Task0V10
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double res = (1.6 * (Math.Pow(2, 3))) - (2.1 * (Math.Pow(x, 2))) - 7 * x;
            res = Math.Round(res, 3);
            File.WriteAllText(path, Convert.ToString(res));
            return path;

        }
    }
}