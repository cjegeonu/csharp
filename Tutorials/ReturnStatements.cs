using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hi
{
    class ReturnStatements
    {
        static void Main(string[] args)
        {
            int cubed = cube(5);
            Console.WriteLine(cubed);

            Console.ReadLine();
        }
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}