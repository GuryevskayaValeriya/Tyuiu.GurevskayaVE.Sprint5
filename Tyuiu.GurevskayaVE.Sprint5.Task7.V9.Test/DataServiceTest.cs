using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GurevskayaVE.Sprint5.Task7.V9.Lib;

namespace Tyuiu.GurevskayaVE.Sprint5.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test7()
        {
            string path = @"C:\DataSprint5\OutPutDataFileTask7V9.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileEx = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileEx);
        }
    }
}
