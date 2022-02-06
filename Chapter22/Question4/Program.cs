using System;
using System.Collections.Generic;
using System.Linq;


namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students=new List<Student>()
            {
                new Student(){FirstName = "Adeolu",LastName = "Ayo",Age = 13},
                new Student(){FirstName = "Olu",LastName = "Ade",Age = 18},
                new Student(){FirstName = "Bayo",LastName = "Ola",Age = 22},
                new Student(){FirstName = "Ada",LastName = "Obi",Age = 19},
                new Student(){FirstName = "Ade",LastName = "Ada",Age = 24},
            };

            var Adult = from student in students where student.Age >= 18 && student.Age <= 24 select student; 
            foreach (var b in Adult)
            {
                Console.WriteLine($"{b.FirstName}  {b.LastName}");
            }
        }
    }
}
