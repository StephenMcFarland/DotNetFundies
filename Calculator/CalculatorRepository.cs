using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorRepository
    {
        
        //Want a method that adds
        public int AddTwoNumbers(int kung, int fu)
        {
            int kungFu = kung + fu;
            return kungFu;
        }

        //Want a method that subtracts
        public int SubtractTwoNumbers(int spaghetti, int sauce)
        {
            int spaghettiSauce = spaghetti - sauce;
            return spaghettiSauce;
        }

        //Want a method that multiplies
        public int MultiplyTwoNumbers(int foot, int ball)
        {
            int footBall = foot * ball;
            return footBall;
        }

        //Want a method that divides
        public int DivideTwoNumbers(int hello, int ball)
        {
            int train = hello + ball;
            return train;
        }
    }
}
