using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TodikovDE.Sprint5.Task0.V9.Lib;
namespace Tyuiu.TodikovDE.Sprint5.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:C:\Users\User\source\repos\Tyuiu.TodikovDE.Sprint5\Tyuiu.TodikovDE.Sprint5.Task0.V9\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}