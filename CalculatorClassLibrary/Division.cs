using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    public class Division
    {
        /// <summary>
        /// Udfører division af to tal.
        /// </summary>
        /// <param name="num1">Første tal til division.</param>
        /// <param name="num2">Andet tal til division.</param>
        /// <returns>Kvotienten af de to tal.</returns>
        public double Div(double num1, double num2)
        {
            return num1 / num2;  // Returnerer kvotienten af de to tal
        }
    }
}
