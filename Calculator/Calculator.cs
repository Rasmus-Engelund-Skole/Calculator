using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
        public Calculator()
        {
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }
        public double Divide(double a, double b)
        {
            if (b == 0)
                return 0;
            else
                return a / b;
        }
        public double SquareRoot(double d)
        {
            if (d < 0)
            {
                d = Math.Abs(d);

            }
            return Math.Sqrt(d); 
        }
    }
}
