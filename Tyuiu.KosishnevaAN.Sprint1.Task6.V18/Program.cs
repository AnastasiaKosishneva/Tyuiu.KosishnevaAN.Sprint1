using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosishnevaAN.Sprint1.Task6.V18.Lib;

namespace Tyuiu.KosishnevaAN.Sprint1.Task6.V18
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
            Console.WriteLine(" Задание #6                                                             *");
            Console.WriteLine(" Вариант #18                                                            *");
            Console.WriteLine(" Выполнила: Косишнева Анастасия Николаенвна | ИСТНб-23-1                *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine(" Написать программу: пользователь вводит текст. Проверить, что строка   *");
            Console.WriteLine(" является символьным представлением натурального числа.                 *");
            Console.WriteLine("*                                                                       *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Введите строку:");
            string x = Console.ReadLine();
            
            
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            if ((ds.CheckNumber(x) == true) && (x[0] != '0'))
            {
                Console.WriteLine("Строка является натуральным числом");
            }
            else
            {
                Console.WriteLine("Строка не является натуральным числом");
            }
            Console.ReadKey();
        }
    }
}
