using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KosishnevaAN.Sprint1.Task4.V6.Lib
{
    public class DataService : ISprint1Task4V6
    {
        public double Calculate(double x, double y)
        {
            var res = (Math.Abs(Math.Pow(y, 2)) - x) / (x * y);
            var res1 = Math.Round(res, 3);
            return res1;
        }
    }
}
