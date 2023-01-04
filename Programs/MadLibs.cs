using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hi
{
    class MadLibs
    {
        static void Main(string[] args)
        {
            string color, noun, name;

            Console.Write("Wjat's your favorite color?: ");
            color = Console.ReadLine();
            Console.Write("Name a noun: ");
            noun = Console.ReadLine();
            Console.Write("What's your name?: ");
            name = Console.ReadLine();

            Console.WriteLine("Roses are " + color + ",");
            Console.WriteLine(noun + " are blue,");
            Console.WriteLine("I love " + name + "!");

            Console.ReadLine();


        }
	}
}

