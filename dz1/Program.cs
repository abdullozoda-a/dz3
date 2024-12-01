using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number: ");int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");int num2 = int.Parse(Console.ReadLine());
            while (num1 >= num2)
            {
                num1 -= num2;
            }
            Console.WriteLine(num1);
        }
    }
}