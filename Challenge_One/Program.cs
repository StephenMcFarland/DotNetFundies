using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_One
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user first name, last name, age
            Console.WriteLine("Hello, what is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello,{firstName} {lastName}, you are a {age}.");

            Console.WriteLine("Hello " + firstName + " " + lastName + " " + age);
            Console.ReadLine();
        }
    }
}
