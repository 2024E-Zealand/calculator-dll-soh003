using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary.Tests
{
    [TestClass]
    public class MultiplicationTests
    {
        private readonly Multiplication _multiplication = new Multiplication();

        [TestMethod]
        [DataRow(5, 3, 15)]     // Test case 1
        [DataRow(-2, 4, -8)]    // Test case 2
        [DataRow(0, 10, 0)]     // Test case 3
        [DataRow(1.5, 2, 3)]    // Test case 4
        public void MultiplyTest(double num1, double num2, double expected)
        {
            // Act
            var result = _multiplication.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}