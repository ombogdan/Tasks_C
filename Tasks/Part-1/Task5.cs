using System;
using static System.Math;

namespace Tasks
{
    public class Task5
    {
        public void Main1()
        {
            Console.WriteLine("Input x ");
            double x = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToInt32(Console.ReadLine());

            double s_a = (x + y) / 2;
            double s_q = Pow((Abs(x)*Abs(y)), 0.5);
            Console.WriteLine("Arithmetic mean: " + s_a);
            Console.WriteLine("Geometric mean: " + s_q);
        }
    }
}