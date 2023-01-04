using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hi
{
    class Student2
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("James", "English", 3.8);
            Student student2 = new Student("Christ", "Math", 2.9);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.ReadLine();
        }
    }
}