using System;
using static System.Math;
namespace Tasks
{
    public class Task9
    {
        public void Main1()
        {
            Console.WriteLine("Input R1 ");
            double r_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input R2 ");
            double r_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input R3 ");
            double r_3 = Convert.ToInt32(Console.ReadLine());
            double res = (1/r_1)+(1/r_2)+(1/r_3);
            Console.WriteLine("Resistance: " + res);
        }
    }
}