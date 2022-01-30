using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new HandlingNegativeException("Number must be greater than 0");
                }

                double a = Math.Sqrt(num);
                Console.WriteLine(a);
            }
            catch (HandlingNegativeException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (Exception  )
            {
                Console.WriteLine("Invalid input");

            }
            finally
            {
                Console.WriteLine("Good Bye");
            }

               

        }
    }
}
