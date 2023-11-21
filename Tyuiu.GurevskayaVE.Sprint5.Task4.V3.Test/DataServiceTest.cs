using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GurevskayaVE.Sprint5.Task4.V3.Lib;

namespace Tyuiu.GurevskayaVE.Sprint5.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test4()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V3.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
