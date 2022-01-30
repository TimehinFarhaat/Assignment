using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatingAndUsingObjects;


namespace Assignment
{


    class Answers
    {
        public static void Question1()
        {
            Console.Write("Enter the year: ");
            int year = int.Parse(Console.ReadLine());
            bool a = DateTime.IsLeapYear(year);
            Console.WriteLine(a);

        }


        public static void Question2()
        {
            for (int i = 0; i < 10; i++)
            {

                Random random = new Random();
                int a = random.Next(100, 201);
                Console.WriteLine(a);
            }
        }




        public static void Question3()
        {
            var a = DateTime.Today.DayOfWeek;
            Console.WriteLine(a);
        }




        public static void Question4()
        {
            int a = Environment.TickCount;
            int seconds = a / 1000;
            int minutes = (seconds / 60);
            int hours = minutes / 60;
            int days = hours    / 24;
            Console.WriteLine($"Seconds: {a}\n"       +
                              $"Minutes: {minutes}\n" +
                              $"Hours :  {hours}\n"   +
                              $"Days :   {days}");
        }




        public static void Question5()
        {
            Console.WriteLine("Enter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            double c = Math.Sqrt(((a * a) + (b * b)));
            Console.WriteLine(c);
        }



        public static void Question6()
        {

            Console.WriteLine("Calculate area \n"                             +
                              "1. Given 3 sides \n"                           +
                              "2. Given a side and its altitude \n"           +
                              "3. Given 2 sides and the angle between them\n" +
                              "Enter option: ");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter a");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter c: ");
                int c = int.Parse(Console.ReadLine());
                int p = (a + b + c) / 2;
                double area = Math.Sqrt((p * ((p - a) * (p - b) * (p - c))));
                Console.WriteLine(area);
            }
            else if (choice == 2)
            {

                Console.WriteLine("Enter side: ");
                int side = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter altitude: ");
                int h = int.Parse(Console.ReadLine());
                float ares = (side * h) / 2;
                Console.WriteLine(ares);


            }
            else if (choice == 3)
            {

                Console.WriteLine("Enter first: ");
                int f = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second side: ");
                int s = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter angle between: ");
                float angle = int.Parse(Console.ReadLine());
                double aresa = (f * s * Math.Sin(angle)) / 2;
                Console.WriteLine(aresa);


            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }


        public static void Question9()
        {
            DateTime time = DateTime.Now.Date;
            Console.Write("Enter the date limit: ");
            DateTime time1 = DateTime.Parse(Console.ReadLine());
            List<DayOfWeek> days = new List<DayOfWeek>();
            int count = 0;
            string b = "";
            for (DateTime i = time; i <= time1;i.AddDays(1))
            {
                var a = time.DayOfWeek;
                if (a == DayOfWeek.Sunday || a == DayOfWeek.Saturday)
                {
                     b = $"{a}   {time.ToString()}";
                   
                }
                else
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            foreach (var day in days)
            {
                Console.WriteLine(day);
            }
        }


        public static void Question10()
        {
            Console.Write("Enter numbers separated by space: ");
            string[] parts = Console.ReadLine().Split(" ");
            Console.Write("Enter how many numbers: ");
            int num = int.Parse(Console.ReadLine());
            float y = 0;
            for (int i = 0; i < num; i++)
            {
                y += Convert.ToSingle(parts[i]);
            }

            Console.WriteLine(y);

        }


        public static void Question11()
        {
            string[] Laudatoryphrases = new[]
                { "The product is excellent.", "This is a greatproduct.", "I use this product constantly.", "This is the best product from this category." };

            string[] LaudatoryStories = new[]
            {
                "Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling  great.",
                "You should try it,too", " I am very satisfied."
            };

            string[] FirstName = new[] { "Dayan", "Stella", "Hellen", "Kate" };
            string[] Lastnameoftheauthor = new[] { "Johnson", "Peterson", "Charls" };
            string[] Cities = new[] { "London", "Paris", "Berlin", "New York", "Madrid" };

            Random random = new Random();
            //  int rand = random.Next(Laudatoryphrases.Length);
            string a = (string) (Laudatoryphrases[0]);

            Random random1 = new Random();
            // int rand1 = random1.Next(LaudatoryStories.Length);
            string b = (string) (LaudatoryStories[0]);

            Random random2 = new Random();
            //int rand2 = random2.Next(FirstName.Length);
            string c = (string) (FirstName[0]);


            Random random3 = new Random();
            // int rand3 = random3.Next(Lastnameoftheauthor.Length);
            string d = (string) (Lastnameoftheauthor[0]);



            Random random4 = new Random();
            // int rand4 = random4.Next(Cities.Length);
            string e = (string) (Cities[0]);


            Console.WriteLine($"{a}, {b}, {b}-----{c} {d}, {e}");



        }

    }
} ///   Question 7
namespace CreatingAndUsingObjects
{

    class Cat
    {

        public string NameCat { get; set; }



        public Cat()
        {
        }


        public Cat(string name)
        {
            NameCat = name;
        }

       

        public static string SayMiau ()
        {
            return $"Cat {Sequence.NextValue()} said: Miauuuuuu!";
        }



    }


   public class Sequence
    {

        public static int currentValue = 0;



        public static int NextValue ()
        {
            currentValue++;
            return currentValue;
        }

    }
}

//Question 8
namespace Assignment
{
    public class Another
    {
        
        public static  void Call10()
        {
            Cat some =new Cat();

            Cat[] arr = new Cat[]
            {
                new Cat("Kitty"),
                new Cat("Kit"),
                new Cat("mitty"),
                new Cat("Mit"),
                new Cat("Jerry"),
                new Cat("calm"),
                new Cat("Ferry"),
                new Cat("Kite"),
                new Cat("Mite"),
                new Cat("Kilt"),
            };

            foreach (var cat in arr)
            {
                Console.WriteLine($"{Cat.SayMiau()}  {cat.NameCat} ");
            }

        }
        

    }

}
















