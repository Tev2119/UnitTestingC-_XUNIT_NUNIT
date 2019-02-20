using System;
using System.Linq;
using Xunit;
using CalculatorStuff;

namespace Tcalculator
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {   //Arrange
            Calculator calc = new Calculator();
            double expected = 6.0;
            //Act
            double actual = calc.Add(2.0, 4.0);
            //Asserty
            Assert.Equal(expected, actual);
        }
        [Fact]//Atributes
        public void TestDivide()
        {
            Calculator calc = new Calculator();
            double expected = 2.0;
            //Act
            double actual = calc.Divide(4.0, 2.0);
            //Asserty
            Assert.Equal(expected, actual);
        }
        [Fact]//Atributes
        public void TestMultiply()
        {
            Calculator calc = new Calculator();
            double expected = 6.0;
            //Act
            double actual = calc.Multiply(2.0, 3.0);
            //Asserty
            Assert.Equal(expected, actual);
        }
        [Fact]//Atributes
        public void TestModula()
        {
            Calculator calc = new Calculator();
            double expected = 2.0;
            //Act
            double actual = calc.Modula(2.0, 4.0);
            //Asserty
            Assert.Equal(expected, actual);
        }
        [Fact]//Atributes
        public void TestSubtract()
        {
            Calculator calc = new Calculator();
            double expected = 0.0;
            //Act
            double actual = calc.Subtract(4.0, 4.0);
            //Asserty
            Assert.Equal(expected, actual);
        }
        [Fact]//Atributes
        public void TestAreaOfCircle()
        {
            Calculator calc = new Calculator();
            double expected = Math.PI;
            //Act
            double actual = calc.AreaOfCircle(Math.PI);
            //Asserty
            Assert.Equal(expected, actual);
        }
        [Fact]//Atributes
        public void TestAreaOfSquare()
        {
            Calculator calc = new Calculator();
            double expected = 16.0;
            //Act
            double actual = calc.AreaOfSquare(4.0);
            //Asserty
            Assert.Equal(expected, actual);
        }
        [Fact]//Atributes
        public void TestAreaOfTriangle()
        {
            Calculator calc = new Calculator();
            double expected = 198.0;
            //Act
            double actual = calc.AreaOfTriangle(33.0, 12.0);
            //Asserty
            Assert.Equal(expected, actual);
        }
    }
}
