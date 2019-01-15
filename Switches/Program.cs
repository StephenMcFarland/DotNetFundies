using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switches
{
    class Program
    {
        static void Main(string[] args)
        {
            //The enum is declared in our SwitchStatements class
            string lastName = "Wagner";
            string firstName = "Kate";
            GenderType gender = GenderType.Female;
            switch (gender)
            {
                case GenderType.Male:
                    Console.WriteLine($"Welcome Mr.{lastName}");
                    break;
                case GenderType.Female:
                    Console.WriteLine($"Welcome Mrs.{lastName}");
                    break;
                case GenderType.UnDeclared:
                    Console.WriteLine($"Welcome {firstName} {lastName}");
                    break;
            }

            Console.WriteLine("How are you feeling on a scale of 1-5?");
            string feelingAsString = Console.ReadLine();
            int feeling = int.Parse(feelingAsString);

            switch (feeling)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("Uh oh");
                    break;
                default:
                case 3:
                    Console.WriteLine("Cool");
                    break;
                case 4:
                    Console.WriteLine("That's good");
                    break;
                case 5:
                    Console.WriteLine("That's awesome!");
                    break;
            }

            if (feeling <= 1)
            {
                Console.WriteLine("Oh no that's terrible");
            }
            else if (feeling == 2)
            {
                Console.WriteLine("Uh oh");
            }
            else if (feeling == 3)
            {
                Console.WriteLine("Cool");
            }
            else if (feeling == 4)
            {
                Console.WriteLine("That's good");
            }
            else if (feeling == 5)
            {
                Console.WriteLine("Awesome!");
            }
            else
            {
                Console.WriteLine("That's off the scale");
            }

            Console.ReadLine();
        }
    }
}
