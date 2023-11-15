using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GurevskayaVE.Sprint5.Task2.V20.Lib;

namespace Tyuiu.GurevskayaVE.Sprint5.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test2()
        {
            string path = @"C:\Users\ВАЛЕРИЯ 2004\source\repos\Tyuiu.GurevskayaVE.Sprint5\Tyuiu.GurevskayaVE.Sprint5.Task2.V10\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
