using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hi
{
    class IfStatementds
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = true;

            // And (both of them have to be true)
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male.");
                // Else if statemtns create another possible scenario. The "!" negates the condition
            } else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male.");
            } else if (!isMale && isTall)
            {
                Console.WriteLine("You are tall and not a male.");
            }
            else
            {
                Console.WriteLine("You are either not male, short, or both.");
            }

            bool isFemale = false;
            bool isShort = false;

            // Or (only one of them have to be true)
            if (isFemale || isShort)
            {
                Console.WriteLine("You are either short, a womanm, or both.");
            }
            else
            {
                Console.WriteLine("You are neither short or a woman.");
            }

            Console.WriteLine(GetMax(2, 10, 7) + " is the greater number.");

            Console.ReadLine();
        }
        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num2)
            {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            } else
            {
                result = num3;
            }

            return result;
        }
    }
}