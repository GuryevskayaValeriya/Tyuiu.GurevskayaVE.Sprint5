using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GurevskayaVE.Sprint5.Task1.V12.Lib;

namespace Tyuiu.GurevskayaVE.Sprint5.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test1()
        {
            string path = @"C:\Users\ВАЛЕРИЯ 2004\source\repos\Tyuiu.GurevskayaVE.Sprint5\Tyuiu.GurevskayaVE.Sprint5.Task1.V12\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
