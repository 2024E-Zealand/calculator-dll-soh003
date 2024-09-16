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
    public class DivisionTests
    {
        private readonly Division _division = new Division();

        [TestMethod]
        [DataRow(10, 2, 5)]     // Test case 1
        [DataRow(9, 3, 3)]      // Test case 2
        [DataRow(-10, 2, -5)]   // Test case 3
        [DataRow(7.5, 2.5, 3)]  // Test case 4
        public void DivTest(double num1, double num2, double expected)
        {
            // Act
            var result = _division.Div(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}