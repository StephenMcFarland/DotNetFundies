using DotNet_Fundamentals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
    [TestClass]
    class ClassExample
    {
        [TestMethod]
        public void MakingACookie()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            cookie.BatchSize = 60;
            cookie.GlutenFree = true;

            Cookie chocolateCookie = new Cookie();
            chocolateCookie.Name = "chocolate chip cookie";
            chocolateCookie.BatchSize = 40;
            chocolateCookie.GlutenFree = false;

            Assert.AreEqual("Snickerdoodle", cookie.Name);
            Assert.AreEqual(60, cookie.BatchSize);
            Assert.AreEqual(true, cookie.GlutenFree);

            Assert.AreEqual("chocolate chip cookie", chocolateCookie.Name);
            Assert.AreEqual(40, chocolateCookie.BatchSize);
            Assert.AreEqual(false, chocolateCookie.GlutenFree);
        }
    }
}
