using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hi
{
    class Song2 
    {
        static void Main(string[] args)
        {
            Song Holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Holiday.getSongCount);

            Song Kashmir = new Song("Kashmir", "Led Zeppelin ", 150);
            Console.WriteLine(Kashmir.getSongCount);

            Console.ReadLine();
        }
    }
}