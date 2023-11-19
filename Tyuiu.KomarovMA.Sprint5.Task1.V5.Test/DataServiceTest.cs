using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint5.Task1.V5.Lib;
using System.IO;
namespace Tyuiu.KomarovMA.Sprint5.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void NotImplementedException()
        {
            string path = @"D:\SOURSE\Tyuiu.KomarovMA.Sprint5\Tyuiu.KomarovMA.Sprint5.Task0.V10\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}