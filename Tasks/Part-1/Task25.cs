using System;
using static System.Math;
namespace Tasks
{
    public class Task25
    {
        public void Main1()
        {
            double x1 = 1;
            double y1 = 2;
            double x2 = 3;
            double y2 = 5;
            double x3 = 5;
            double y3 = 10;
            double st1 = Math.Pow((x1 - x2), 2 + Pow((y1 - y2), 2));
            double st2 = Pow((x2 - x3), 2) + Pow((y2 - y3),2);
            double st3 = Math.Pow((x3 - x1), 2) + Pow((y3 - y1), 2);
            double p = st1 + st2 + st3; //perimetr
            double pp = p / 2;
            double s = Pow(pp * (pp - st1) * (pp - st2) * (pp - st3), 2); //Square
            Console.WriteLine("Площа S ="+ s + "; Периметер P = " + p);

        }
    }
}