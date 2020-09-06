using System;
using static System.Math;
namespace Tasks
{
    public class Task10
    {
        public void Main1()
        {
            Console.WriteLine("Input heigth ");
            double h = Convert.ToInt32(Console.ReadLine());
            double g = 9.8;
            double t = (2*h)/g;
            Console.WriteLine("Resistance: " + t);
        }
    }
}