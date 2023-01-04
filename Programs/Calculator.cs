using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hi
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter another number: ");

            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(num1 + num2);
            } else if (op == "-")
            {
                Console.Write(num1 - num2);
            } else if (op == "/")
            {
                Console.Write(num1 / num2);
            } else if (op == "*")
            {
                Console.Write(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }

            Console.ReadLine();
		}
	}
}

