﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosishnevaAN.Sprint1.Task3.V14.Lib;

namespace Tyuiu.KosishnevaAN.Sprint1.Task3.V14
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
            Console.WriteLine("* Задание #3                                                            *");
            Console.WriteLine("* Вариант #14                                                           *");
            Console.WriteLine("* Выполнила: Косишнева Анастасия Николаенвна | ИСТНб-23-1               *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу, которая позволяет определить число, полученное    *");
            Console.WriteLine("* выписыванием в обратном порядке цифр заданного трехзначного числа.    *");
            Console.WriteLine("*                                                                       *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            double n;
            Console.WriteLine("Введите исходное число");



            n = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("Перевернутое число = " + ds.ReverseNumber(n));
            Console.ReadKey();
        }
    }
}
