using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hi
{
    class WhileLoops
    {
        static void Main(string[] args)
        {
            int index = 1;
            // This will run the code until it is false
            while (index <= 5)
            {
                Console.WriteLine(index + " is less than or equal to 5.");
                index++;
            }

            Console.ReadLine();
        }
    }
}