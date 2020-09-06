using System;
using static System.Math;
namespace Tasks
{
    public class Task30
    {
        public void Main1()
        {
            Console.WriteLine("Input x ");
            double x = Convert.ToInt32(Console.ReadLine());
            
            double q = 1 - 2 * x + 3 * Pow(x, 2) - 4 * Pow(x, 3);
            double z = 1 + 2 * x + 3 * Pow(x, 2) - 4 * Pow(x,3);
            Console.WriteLine("Equation1: " + q);
            Console.WriteLine("Equation2: " + z);
        }
    }
}