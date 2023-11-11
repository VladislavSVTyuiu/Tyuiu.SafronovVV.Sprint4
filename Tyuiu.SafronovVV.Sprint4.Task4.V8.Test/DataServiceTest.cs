﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SafronovVV.Sprint4.Task4.V8.Lib;

namespace Tyuiu.SafronovVV.Sprint4.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] num = new int[5, 5]
            {
                { 1, 3, 2, 2, 5 },
                { 6, 1, 5, 5, 2 },
                { 1, 5, 4, 1, 4 },
                { 4, 1, 4, 4, 5 },
                { 4, 6, 1, 1, 4 }
            };
            int[,] res = ds.Calculate(num);
            int[,] wait = new int[5, 5]
            {
                { 1, 3, 1, 1, 5 },
                { 1, 1, 5, 5, 1 },
                { 1, 5, 1, 1, 1 },
                { 1, 1, 1, 1, 5 },
                { 1, 1, 1, 1, 1 }
            };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
