using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosishnevaAN.Sprint1.Task2.V5.Lib;

namespace Tyuiu.kosishnevaAN.Sprint1.Task2.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Косишнева А. Н. | ИСТНб-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #1                                                             *");
            Console.WriteLine("* Тема: Базовые навыки в C#                                             *");
            Console.WriteLine(" Задание #2                                                             *");
            Console.WriteLine(" Вариант #5                                                             *");
            Console.WriteLine(" Выполнила: Косишнева Анастасия Николаенвна | ИСТНб-23-1                *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine(" Известна длина стороны куба. Вычислить площадь боковой поверхности     *");
            Console.WriteLine(" куба.                                                                  *");
            Console.WriteLine("*                                                                       *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            int x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("площадь боковой поверхности куба = " + ds.CalculateSideSquare(x));
            Console.ReadKey();
        }
    }
}
