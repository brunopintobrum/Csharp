using System;
using System.IO;

namespace StreamWriter_Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"F:\OneDrive\Cursos Udemy\C# COMPLETO 2020\StreamWriter_Example01\temp\file01.txt";
            string targetPath = @"F:\OneDrive\Cursos Udemy\C# COMPLETO 2020\StreamWriter_Example01\temp\file02.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
