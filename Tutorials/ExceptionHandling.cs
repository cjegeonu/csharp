using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hi
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            // The try function tests code that might cause an error
            try
            {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 / num2);
            }
            // The catch function stops the code from crashing from an error
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}