using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KomarovMA.Sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\Users\masan\SHARP\OutPutDataFileTask7V29.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        if (string.IsNullOrWhiteSpace(word))
                        {
                            if (int.TryParse(word, out int _))
                            {
                                if (word.Length > 1)
                                {
                                    File.AppendAllText(pathSaveFile, word + " ");
                                }
                            }
                            else
                            {
                                File.AppendAllText(pathSaveFile, word + " ");
                            }
                        }
                    }
                    File.AppendAllText(pathSaveFile, Environment.NewLine);
                }
            }

            return pathSaveFile;
        }
    }
}