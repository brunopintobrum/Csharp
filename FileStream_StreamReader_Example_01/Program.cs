using System;
using System.IO;

namespace FileStream_StreamReader_Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\OneDrive\Cursos Udemy\C# COMPLETO 2020\FileStream_StreamReader_Example_01\temp\file01.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                //while (!sr.EndOfStream) *** imprime todas as linhas
                //{
                //    string line = sr.ReadLine();
                //    Console.WriteLine(line);
                //}
                string line = sr.ReadLine(); //imprime só a primeira linha
                Console.WriteLine(line);

            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
