using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}. Nice to meet you.");
            Console.ReadKey();
        }
    }
}
