using System;

namespace Fraction1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = InputOutput();
            Console.WriteLine("Input arithmetic operation: + - *");
            string b = Console.ReadLine();
            Console.WriteLine(Count(result, b));
            
        }

        static int[] InputOutput()
        {
            Console.WriteLine("Input first  variable ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second  variable ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[] myIntArray = new int[2] { a, b};
            return myIntArray;
        }
        
        static double Count(int[] number, string arithmetic_operation)
        {
            if (arithmetic_operation == "+")
            {
                double result = number[0] + number[1];
                return result;
            }
            else if (arithmetic_operation=="-")
            {
                double result = number[0] - number[1];
                return result;
            }
            else if (arithmetic_operation=="*")
            {
                double result = number[0] * number[1];
                return result;
            }
            return -1;
        }
    }
}