using System;
using System.Linq;
using System.Text;

namespace Inverse_Name_With_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            string nameReverse = new string(name.Reverse().ToArray());

            Console.WriteLine($"Inverted name: {nameReverse}");

        }
    }
}
