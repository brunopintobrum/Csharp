using System;
using System.IO;

namespace File_FileInfo_IOException_Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"F:\OneDrive\Cursos Udemy\C# COMPLETO 2020\File_FileInfo_IOException_Example_01\temp\file1.txt";
            string targetPath = @"F:\OneDrive\Cursos Udemy\C# COMPLETO 2020\File_FileInfo_IOException_Example_01\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath); //

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
