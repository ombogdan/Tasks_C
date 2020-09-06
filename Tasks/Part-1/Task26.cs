using System;
using static System.Math;
namespace Tasks
{
    public class Task26
    {
        public void Main1()
        {
            Console.WriteLine("Input value ");
            double phi = Convert.ToInt32(Console.ReadLine());

            double s = phi * Pow(((13.7) / 2), 2);
            Console.WriteLine("Square: " + s);
        }
    }
}