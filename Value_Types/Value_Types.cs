using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Value_Types
{
    [TestClass]
    public class Value_Types
    {
        [TestMethod]
        public void ValueTypes()
        {
            //Character
            char c = 'i';

            //Boolean
            bool on = false;
            bool off = true;

            //Numbers
            byte by = 255;

            short sh = 32000;
            long l = 98787;


            int intMin = -2147483648;
            int intMax = 2147483647;

            float floatExample = 1.978f;
            double doubleExample = 0.9998d;
            decimal decimalExample = 9.8989m;

            DateTime today = DateTime.Now;
            DateTime someDay = new DateTime(1978, 1, 1);
        }

        [TestMethod]
        public void Declaration()
        {
            int number;
            string name;
            bool isValid;
            decimal money;
            short sh;
            byte bit;
        }
        [TestMethod]
        public void Declaration_Than_Initialiazation()
        {
            int number;
            string name;
            bool isValid;
            decimal money;
            short sh;
            byte bit;

            number = 1;
            name = "Lawrence";
            isValid = false;
            money = 3.456m;
            sh = 32000;
            bit = 22;
        }
        [TestMethod]
        public void DeclarationAndInitialization()
        {
            int number = 1;
            string name = "Larry";
            bool isValid = false;
            decimal money = 3.509m;
            short sh = 3450;
            byte bit = 245;
        }
    }
}
