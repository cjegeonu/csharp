using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hi
{
    class Book2
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            Console.WriteLine(book1.title + " is written by " + book1.author + " and has " + book1.pages + " pages.");

            Book book2 = new Book("Lord of the Rings", "JRR Tolkein", 800);

            Console.WriteLine(book2.title + " is written by " + book2.author + " and has " + book2.pages + " pages.");


            Console.ReadLine();
        }
    }
}