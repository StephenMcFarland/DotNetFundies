using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
    [TestClass]
    public class Operators_And_Methods
    {
        [TestMethod]
        public void UsingOperators()
        {
            int number = 10;
            int numberTwo = 10;

            int c = number + numberTwo;
            Assert.AreEqual(20, c);
        }
    }
}
