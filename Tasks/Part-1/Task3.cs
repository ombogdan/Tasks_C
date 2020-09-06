using System;
namespace Tasks
{
    public class Task3
    {
        public void Main1()
        {
            Console.WriteLine("Input x ");
            double x = Convert.ToInt32(Console.ReadLine());

            double v = Math.Pow(x, 3);
            double s = Math.Pow(x, 2);
            Console.WriteLine("Volume: " + v);
            Console.WriteLine("Square: " + s);
        }
    }
}