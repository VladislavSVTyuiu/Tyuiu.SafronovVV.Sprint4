﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SafronovVV.Sprint4.Task6.V17.Lib;

namespace Tyuiu.SafronovVV.Sprint4.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var codes = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            int res = ds.Calculate(codes);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
