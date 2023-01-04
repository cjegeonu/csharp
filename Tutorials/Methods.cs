using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hi
{
    class Methods
    {
        static void Main(string[] args)
        {
            HelloWorld("James", 15);
            HelloWorld("Mike", 19);
            HelloWorld("Chris", 22);

            Console.ReadLine();
        }

        static void HelloWorld(string name, int age)
        {
            Console.WriteLine("Hello " + name + ", you are " + age);
        }

    }
}