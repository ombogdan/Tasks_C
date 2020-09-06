using System;
using static System.Math;
namespace Tasks
{
    public class Task8
    {
        public void Main1()
        {
            Console.WriteLine("Input n ");
            double n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input radius ");
            double r = Convert.ToInt32(Console.ReadLine());
            double p = 2+r+PI/n;
            Console.WriteLine("Perimetr: " + p);
        }
    }
}