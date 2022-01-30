using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;


namespace Question11
{
    class Program
    {
        private static StreamReader reader;

        static void Main(string[] args)
        {
            //Console.Write("Enetr the file path: ");
            //string path = Console.ReadLine();

            MethodNumber();
        }


        public static string MethodNumber()
        {
            int i = 0;
            try
            {
                
                string file = "C:\\Users\\staa99\\source\\repos\\StockManagement\\StockManagement\\Files\\managerFile.txt";
                string[] files = File.ReadAllLines(file);
                foreach (var lane in files)
                {
                    i++;
                    if (!lane.Any(char.IsDigit))
                    {
                        throw new FileParseException("Line does not contain integer", "managerFile", i);
                    }

                }
                

            }
            catch (FileParseException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (Exception )
            {
                Console.WriteLine("File is not valid");

            }
            finally
            {
                Console.WriteLine("Welcome");
            }

            return null;
        }


     


    }
}
 