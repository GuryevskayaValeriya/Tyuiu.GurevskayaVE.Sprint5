using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GurevskayaVE.Sprint5.Task6.V6.Lib;

namespace Tyuiu.GurevskayaVE.Sprint5.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test61()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V6.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 22;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Test62()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V6.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileEx = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileEx);
        }
    }
}
