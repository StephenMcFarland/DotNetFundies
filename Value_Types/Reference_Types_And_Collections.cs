using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
    [TestClass]
    public class Reference_Types_And_Collections
    {
        [TestMethod]
        public void ReferenceTypes()
        {
            //Classes
            //Interfaces
            //Objects

            string hello = "Whatever I want.";
        }

        [TestMethod]
        public void Collections()
        {
            string[] arrayOfStrings = { "This", "can", "be", "a", "collection of any string" };
            List<string> listOfStrings = new List<string>();
            Queue<string> firstInFirstOut = new Queue<string>();
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }

        [TestMethod]
        public void SayHello()
        {
            string name = "John";
            string actual = SayHello(name);
            Assert.AreEqual("Hello, John", actual);
        }

        //Challenge write a method that will take a parameter of a string and then add that string to a sentence. Output it to the test runner.
        private string SayHello(string hello)
        {

            string greeting = "Hello, " + hello;
            Console.WriteLine($"Hello, {hello}");

            return greeting;
        }
    }
}
