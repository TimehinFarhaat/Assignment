using System;

namespace Chapter16
{
    class Program
    {
        static void Main(string[] args)
        {
          
            bool s = true;
            while (s)
            {
                Console.WriteLine("Enter 1-18: ");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Answers.Question1();
                        break;
                    case 2:
                        Answers.Question2();
                        break;
                    case 3:
                        Answers.Question3();
                        break;
                    case 4:
                        Answers.Question4();
                        break;
                    case 5:
                        Answers.Question5();
                        break;
                    case 6:
                        Answers.Question6();
                        break;
                    case 7:
                        Answers.Question7();
                        break;
                    case 8:
                        Answers.Question8();
                        break;
                    case 9:
                        Answers.Question9();
                        break;
                    case 10:
                        Answers.Question10();
                        break;
                   default:
                       s = false;
                       break;
                }
            }
            
        }
    }
}
