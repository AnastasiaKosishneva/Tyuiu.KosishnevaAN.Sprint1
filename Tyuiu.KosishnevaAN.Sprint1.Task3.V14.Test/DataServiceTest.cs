using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosishnevaAN.Sprint1.Task3.V14.Lib;

namespace Tyuiu.KosishnevaAN.Sprint1.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double n = 1235;
            double wait = 532;
            var res = ds.ReverseNumber(n);
            Assert.AreEqual(wait, res);
        }
    }
}
