using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Value_Types
{
    [TestClass]
    public class ForLoop
    {
        [TestMethod]
        public void ForName()
        {
            string name = "Eleven Fifty Academy";
            for(int i = 0; i <= name.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
