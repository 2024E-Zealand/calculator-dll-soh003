using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    public class Subtraction
    {
        /// <summary>
        /// Udfører subtraktion af to tal.
        /// </summary>
        /// <param name="num1">Første tal til subtraktion.</param>
        /// <param name="num2">Andet tal til subtraktion.</param>
        /// <returns> resultat af subtraktion.</returns>
        public double Sub(double num1, double num2)
        {
            return num1 - num2;  // Returnerer resultatet af subtraktion
        }
    }
}
