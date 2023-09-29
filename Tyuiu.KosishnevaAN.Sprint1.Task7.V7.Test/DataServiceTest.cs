using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosishnevaAN.Sprint1.Task7.V7.Lib;
namespace Tyuiu.KosishnevaAN.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            double wait = 14.47;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
