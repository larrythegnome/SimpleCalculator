using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double result;
            string operation;

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation (+, -, *, /): ");
            operation = Console.ReadLine();

            switch (operation) 
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("invalid opration.");
                    return;
            }

            Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");
            Console.ReadLine();
        }
    }
}
