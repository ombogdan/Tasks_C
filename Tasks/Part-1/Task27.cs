﻿using System;
using static System.Math;
namespace Tasks
{
    public class Task27
    {
        public void Main1()
        {
            double a = 3;
            double b = 3;
            double c = 3;
            double s = a + b + c;
            double ca = 180 * a / s;
            double cb = 180 * b / s;
            double cc = 180 * c / s;
            Console.WriteLine("Кут BAC " + ca);
            Console.WriteLine("Кут ABC " + cb);
            Console.WriteLine("Кут BCА " + cc);
        }
    }
}