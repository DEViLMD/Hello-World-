using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("What's your name?");
            string yourName;
            yourName = Console.ReadLine();
            Console.Write("Hello {0}.", yourName);
            Console.WriteLine("Are you looking for a job?");
            string answer1;
            string yes;
            answer1 = Console.ReadLine();
            if (answer1 == yes) 
            {
                Console.WriteLine("Ok. How old are you?");
            }
            else
            {

            }
        }
    }
}
