using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class SimpleCalculator
    {
        public static decimal Calculate(decimal value1,decimal value2,string MathOperator)
        {
            decimal result = 0;
            switch (MathOperator) {
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
                case "x":
                    result = value1 * value2;
                    break;
                case "/":
                    result = value1 / value2;
                    break;
            }

            return result;
            

        }
    }
}
