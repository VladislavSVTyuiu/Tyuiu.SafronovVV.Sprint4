using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SafronovVV.Sprint4.Task0.V18.Lib;

namespace Tyuiu.SafronovVV.Sprint4.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] ar = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            int res = ds.GetSumOddArrEl(ar);
            int wait = 41;
            Assert.AreEqual(res, wait);
        }
    }
}
