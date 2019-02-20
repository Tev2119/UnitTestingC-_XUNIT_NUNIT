using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStuff
{
    public class Calculator
    {
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        public double Divide(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        public double Modula(double num1, double num2)
        {
            double result = num1 % num2;
            return result;
        }
        public double Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        public double AreaOfCircle(double num1)
        {
            num1 = Math.PI;
            double result = Math.PI;
            return result;
        }
        public double AreaOfSquare(double num1)
        {
            double result = num1 * num1;
            return result;
        }
        public double AreaOfTriangle(double BaseOfTriangle, double HeightOfTriangle)
        {
            double result = (BaseOfTriangle * HeightOfTriangle) / 2;
            return result;
        }

    }
}
