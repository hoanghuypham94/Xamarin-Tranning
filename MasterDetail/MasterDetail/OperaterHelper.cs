using System;

using Xamarin.Forms;

namespace MasterDetail
{
    public class OperaterHelper : ContentPage
    {
        public static double Calculate(double value1, double value2, string myoperator)
        {
            double result = 0;
            switch (myoperator)
            {
                case "/":
                    result = value1 / value2;
                    break;
                case "X":
                    result = value1 * value2;
                    break;
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;

            }
            return result;
        }
    }
}

