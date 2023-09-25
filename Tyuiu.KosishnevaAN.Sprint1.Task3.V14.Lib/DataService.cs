using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KosishnevaAN.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            string str = Convert.ToString(number);
            char[] carr = str.ToCharArray();
            Array.Reverse(carr);
            str = new string(carr);
            str = str.Substring(0, 3);
            number = Convert.ToDouble(str);
            return number;
        }
    }
}
