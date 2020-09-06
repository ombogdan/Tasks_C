using System;
using static System.Math;
namespace Tasks
{
    public class Task28
    {
        public void Main1()
        {
            Console.WriteLine("Input x ");
            double x = Convert.ToInt32(Console.ReadLine());

            double q = Pow((2 * x), 24) - Pow((3 * x), 3) + Pow((4 * x), 2) - 5 * x + 6;
            Console.WriteLine("Equation: " + q);
        }
    }
}