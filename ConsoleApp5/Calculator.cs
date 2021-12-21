using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Calculator
    {
       

        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Mult(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("You cannot divide on zero");
            }
            else
            {
                return a / b;
            }
            
        }

        public static double Square(double a)
        {
            if (a < 0)
            {
                throw new ArgumentOutOfRangeException("You cannot get a square root from negative number");
            }
            else
            { 
                return Math.Sqrt(a); 
            }
        }

        
    }
}
