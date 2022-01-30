using System;
using Assignment;
using Microsoft.Win32.SafeHandles;


namespace File_and_Stream
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your choice from 1-11 and press 13 to exit: ");
            var choice = int.Parse(Console.ReadLine());
            bool opt = true;
            while (opt)
            {
                switch (choice)
                {
                    case 1:
                        Answers.Question1();
                        Console.ReadKey();
                        break;
                    case 2:
                        Answers.Question2();
                        Console.ReadKey();
                        break;
                    case 3:
                        Answers.Question3();
                        Console.ReadKey();
                        break;
                    case 4:
                        Answers.Question4();
                        Console.ReadKey();
                        break;
                    case 5:
                        Answers.Question5();
                        Console.ReadKey();
                        break;
                    case 6:
                        Answers.Question6();
                        Console.ReadKey();
                        break;
                    case 7:
                        Another.Call10();
                        Console.ReadKey();
                        break;
                    case 8:
                        Another.Call10();
                        Console.ReadKey();
                        break;
                    case 9:
                        Answers.Question9();
                        break;
                    case 10:
                        Answers.Question10();
                        Console.ReadKey();
                        break;
                    case 11:
                        Answers.Question11();
                        Console.ReadKey();
                        break;
                    case 13:
                        opt = false;
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Console.ReadKey();
                        break;

                }
            }


        }
    }
}
