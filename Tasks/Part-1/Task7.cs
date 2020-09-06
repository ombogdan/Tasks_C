using System;
using static System.Math;
namespace Tasks
{
    public class Task7
    {
        public void Main1()
        {
            Console.WriteLine("Input t1 ");
            double t_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input t2 ");
            double t_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input V1 ");
            double v_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input V2 ");
            double v_2 = Convert.ToInt32(Console.ReadLine());

            double v = v_1+v_2;
            double t = (v_1 * t_1 + v_2 * t_2) / (v_1 + v_2);
            Console.WriteLine("Volume: " + v);
            Console.WriteLine("Temperature: " + t);
        }
    }
}