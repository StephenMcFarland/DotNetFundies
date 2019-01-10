using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Value_Types
{
    [TestClass]
    public class If_ElseIf_Else
    {
        [TestMethod]
        public void If_Else()
        {
            //switch to 2 != 2 after they see the output and change message.
            if (2 == 2)
            {
                Console.WriteLine("Of course those are equal");
            }

            // type  name       what goes in that box
            DateTime birthday = new DateTime(1991, 12, 24);
            //Pascal camel
            DateTime date = DateTime.Now;

            if (birthday.Month == date.Month && birthday.Day == date.Day)
            {
                Console.WriteLine("Happy Birthday!!");
            }
            else
            {
                Console.WriteLine("It is not your birthday, but we are looking forward to it!!");
            }

            //Second If
            int age = 14;

            if (age <= 18)
            {
                Console.WriteLine("Still a kid.");
            }
            else if (age > 18 && age < 25)
            {
                Console.WriteLine("You be an adult.");
            }
            else if (age >= 25 && age <= 50)
            {
                Console.WriteLine("You rent car cheap.");
            }
            else
            {
                Console.WriteLine("You be wise.");
            }
        }

        //Challenge make a if else statement based on a true bool value. Have it output to the test runner. make your if statement output with the console whether you are a coder or not.
        [TestMethod]
        public void IfElse()
        {
            bool coder = true;
            if (coder == true)
            {
                Console.WriteLine("Keep mastering the art grasshopper.");
            }
            else
            {
                Console.WriteLine("Don't give up");
            }
        }

        //Make a if else if else state that based on checking the cost of a item
        [TestMethod]
        public void IfElseIfElse()
        {
            float cost = 9.99f;

            if (cost < 5.01f)
            {
                Console.WriteLine("This is a good deal");
            }
            else if (cost >= 5.02f && cost <= 9.03f)
            {
                Console.WriteLine("This may be to expensive");
            }
            else
            {
                Console.WriteLine("You be crazy");
            }
            //You can also use the || Or 
        }

        [TestMethod]
        public void IfElseIfElseChallenge()
        {
            //3.Write a if else if else that asks the user how much money they make a year $1, $50, or $100. Output to the test runner based on each salary range.
            Console.WriteLine("How much do you make?\r\n");
            int input = 13;
            if (input <= 1 || input <= 49)
            {
                Console.WriteLine("Cool");
            }
            else if (input <= 50)
            {
                Console.WriteLine("Okay");
            }
            else if (input <= 100)
            {
                Console.WriteLine("That is a little bit");
            }
            else
            {
                Console.WriteLine("what do you do?");
            }
        }
    }
}
