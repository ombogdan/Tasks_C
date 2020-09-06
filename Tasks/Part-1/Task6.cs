using System;
using static System.Math;
namespace Tasks
{
    public class Task6
    {
        public void Main1()
        {
            Console.WriteLine("Input x ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input y ");

            double y = Convert.ToInt32(Console.ReadLine());

            double gip = Pow(Pow(x, 2) + Pow(y, 2),  1/2);
            double s = Pow(x*y, 2);
            Console.WriteLine("Arithmetic mean: " + gip);
            Console.WriteLine("Geometric mean: " + s);
        }
    }
}