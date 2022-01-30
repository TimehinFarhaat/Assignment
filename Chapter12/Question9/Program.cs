using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = "NewFile.txt";
            Console.WriteLine(ReadFile(FileName));   
        }


        public static string ReadFile(string fileName)
        {
            try
            {    
                string file = "D:\\staa99\\Desktop\\Ass\\Chapter12\\Question9m\\Files\\NewFile.txt";

                if (File.Exists(file))
                {
                    List<string> lines = File.ReadAllLines(file).ToList();
                    lines.Add("I am  a girl");
                    File.WriteAllLines(file, lines);

                    if (lines.Count == 0)
                    {
                        throw new EmptyFileException("The file is empty.Add to it ");
                    }
                    else
                    {
                        foreach (var word in lines)
                        {
                            return word.ToString();
                        }
                    } 
                  
                }
                else
                {
                    string path = "D:\\staa99\\Desktop\\Ass\\Chapter12\\Question9\\Files\\";
                    Directory.CreateDirectory(path);

                    string FileName = fileName;
                    string fullPath = Path.Combine(path, FileName);
                    File.Create(fullPath);
                }


            }
            catch (EmptyFileException e)
            {
                Console.WriteLine(e.Message);
                
            }
            catch (Exception)
            {
                Console.WriteLine("Add to the file");
            }

            return null;
        }


    }
}
