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
            string hello = "why are we doing this?!";
        }

        [TestMethod]
        public void Collections()
        {
            string[] arrayOfStrings = { "This", "can", "hold", "different things" };
            List<string> listOfStrings = new List<string>();
            Queue<string> firstInFirstOut = new Queue<string>();
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }

        [TestMethod]
        public void MyTestMethod()
        {

        }
    }
}
