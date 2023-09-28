using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosishnevaAN.Sprint1.Task6.V18.Lib;

namespace Tyuiu.KosishnevaAN.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSrting()
        {
            string str = " 12 3";
            DataService ds = new DataService();
            bool res = ds.CheckNumber(str);
            bool wait = false;
            Assert.AreEqual(wait, res);

        }
    }
}
