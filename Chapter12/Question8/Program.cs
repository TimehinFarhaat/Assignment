using System;
using System.Net.Http;


namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
           ReadNumber();
        }


        public static void ReadNumber()
        {
            Console.Write("Enter a number: ");

            try
            {
                int num = int.Parse(Console.ReadLine());
                int a = 0;
                a = num;
                if (num < 100)
                {
                    for (int i = 0; i < 9; i++)
                    {

                        Console.Write("Enter a number: ");
                        int num1 = int.Parse(Console.ReadLine());
                        if (a >= num1)
                        {
                            throw new LowerException("Number should be greater than the first");
                        }
                        a = num1;
                        if (a >= 100)
                        {
                            throw new LowerException("Number should be less than 100");
                        }


                      
                    }
                }
                else
                {
                    throw new LowerException("Number should be less than 100");
                }
            }
            catch (LowerException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");

            }
        }
    }
}
