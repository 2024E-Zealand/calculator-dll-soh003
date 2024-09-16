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
    public class additionTests
    {
        private readonly Addition _addition = new Addition();

        [TestMethod]
        [DataRow(10, 20, 30)]   // Test case 1
        [DataRow(-5, 15, 10)]   // Test case 2
        [DataRow(0, 0, 0)]      // Test case 3
        [DataRow(1.5, 2.5, 4)]  // Test case 4
        public void AddTest(double num1, double num2, double expected)
        {
            // Act
            var result = _addition.Add(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}