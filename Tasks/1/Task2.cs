using System;
namespace Tasks
{
    public class Task2
    {
        public void Main1()
        {
            Console.WriteLine("Input a ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input b ");
            var b = Convert.ToInt32(Console.ReadLine());
            var sum = a + b;
            Console.WriteLine("Summ: " + sum);
            var diff = a - b;
            Console.WriteLine("Difference: " + diff);
            var mult = a * b;
            Console.WriteLine("Multiplication: " + mult);
        }
    }
}