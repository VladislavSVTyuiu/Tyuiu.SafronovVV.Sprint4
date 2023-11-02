using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SafronovVV.Sprint4.Task1.V9.Lib;

namespace Tyuiu.SafronovVV.Sprint4.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8 };

            int res = ds.Calculate(numsArray);
            int wait = 4608;

            Assert.AreEqual(wait, res);
        }
    }
}
