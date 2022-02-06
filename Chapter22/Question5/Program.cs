using System;
using System.Collections.Generic;
using System.Linq;


namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students=new List<Student>()
            {
                new Student(){FirstName = "Adeolu",LastName = "Ayo",Age = 16},
                new Student(){FirstName = "Olu",LastName = "Ade",Age = 13},
                new Student(){FirstName = "Bayo",LastName = "Ola",Age = 14},
                new Student(){FirstName = "Ada",LastName = "Obi",Age = 19},
                new Student(){FirstName = "Ade",LastName = "Ada",Age = 15},
            };

            var s = students.OrderByDescending(s => s.FirstName).ThenByDescending(f => f.LastName);
            foreach (var person in s)
            {
                Console.WriteLine($"{person.FirstName}\t {person.LastName}\t  {person.Age}");
            }

            Console.WriteLine();
            var student = from person in students.OrderByDescending(d => d.FirstName).ThenByDescending(u => u.LastName) select person;
            foreach (var person in student)
            {
                Console.WriteLine($"{person.FirstName}\t {person.LastName}\t   {person.Age}");
            }



        }
    }
}
