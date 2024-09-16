using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    public class Multiplication
    {
        /// <summary>
        /// Udfører multiplikation af to tal.
        /// </summary>
        /// <param name="num1">Første tal til multiplikation.</param>
        /// <param name="num2">Andet tal til multiplikation.</param>
        /// <returns>Produktet af de to tal.</returns>
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;  // Returnerer produktet af de to tal
        }
    }
}
