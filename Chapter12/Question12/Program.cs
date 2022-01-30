using System;
using System.IO;


namespace Question12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReadFile();
        }


        public static void ReadFile()
        {

            Console.Write("Enter the full path of the file: ");
            string filePath = Console.ReadLine();
            try
            {

                var files = File.ReadAllLines(filePath);
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            finally
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}
