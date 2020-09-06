using System;
using static System.Math;
namespace Tasks
{
    public class Task29
    {
        public void Main1()
        {
            Console.WriteLine("Input x ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input y ");
            double y = Convert.ToInt32(Console.ReadLine());
            
            double q = 3 * Pow(x, 2) * Pow(y, 2) - (2 * x) * Pow(y, 2) - (7 * Pow(x, 2) * y) - 4 * Pow(y, 2) + 15 * x * y + 2 * Pow(x, 3) - 3 * x + 10 * y + 6;
            Console.WriteLine("Equation: " + q);
        }
    }
}