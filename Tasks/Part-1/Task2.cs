using System;
namespace Tasks
{
    public class Task2
    {
        public void Main1()
        {
            Console.WriteLine("Input x ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input y ");
            double y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Abs(x) - Math.Abs(y) / 1+Math.Abs(x*y));
            double cnt = (Math.Abs(x) - Math.Abs(y)) / (1+Math.Abs(x*y));
            Console.WriteLine("Count: " + cnt);
        }
    }
}