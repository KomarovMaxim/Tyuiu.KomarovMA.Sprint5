using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint5.Task6.V22.Lib;
namespace Tyuiu.KomarovMA.Sprint5.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string path = @"C:\Users\masan\SHARP\InPutDataFileTask6V22.txt";
            int res = dataService.LoadFromDataFile(path), wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}