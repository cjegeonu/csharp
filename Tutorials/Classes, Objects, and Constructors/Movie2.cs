using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hi
{
    class Movie2
    {
        static void Main(string[] args)
        {
            Movie Avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie Cars = new Movie("Cars", "John Lasseter", "Ggggggg");

            Console.WriteLine(Avengers.title + " is directed by " + Avengers.director + " and has a rating of " + Avengers.Rating);
            Console.WriteLine(Cars.title + " is directed by " + Cars.director + " and has a rating of " + Cars.Rating);

            Console.ReadLine();
        }
    }
}