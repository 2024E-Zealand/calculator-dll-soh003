using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly Subtraction _subtraction = new Subtraction();

        [TestMethod]
        [DataRow(20, 10, 10)]    // Test case 1
        [DataRow(15, 5, 10)]     // Test case 2
        [DataRow(0, 0, 0)]       // Test case 3
        [DataRow(5.5, 2.5, 3)]   // Test case 4
        public void SubTest(double num1, double num2, double expected)
        {
            // Act
            var result = _subtraction.Sub(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}