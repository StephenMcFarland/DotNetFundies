using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void Switches()
        {
            int input = 2;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("What you doing");
                    break;
                default:
                    Console.WriteLine("this is default");
                    break;
            }
        }

        public enum GenderType
        {
            Male, Female, UnKnown
        }
        [TestMethod]
        public void Enum()
        {
            GenderType gender = GenderType.Male;
            string lastName = "McClellan";
            string firstName = "Thomas";
            switch (gender)
            {
                case GenderType.Male:
                    Console.WriteLine($"Welcome Mr. {lastName}");
                    break;

                case GenderType.Female:
                    Console.WriteLine($"Welcome Ms. {lastName}");
                    break;

                case GenderType.UnKnown:
                    Console.WriteLine($"Welcome {firstName} {lastName}");
                    break;
            }
            Assert.AreEqual(GenderType.Male, gender);
        }

        //2. Write a switch case that asks the user if they are wearing clothes or some other question
        [TestMethod]
        public void SwitchChallenge()
        {
            string input = "y";
            switch (input)
            {
                case "y":
                    Console.WriteLine("Thank you");
                    break;
                case "n":
                    Console.WriteLine("Put something on");
                    break;
                default:
                    Console.WriteLine("What are you wearing");
                    break;
            }
        }
    }
}
