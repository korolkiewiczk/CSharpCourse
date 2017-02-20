using System;
using System.Collections.Generic;

namespace P13Functions
{
    class Calculator2
    {
        public static void Entry()
        {
            Console.WriteLine("Podaj wyrażenie: ");
            string expression = Console.ReadLine();
            string[] tokens = expression.Split(' ');
            Stack<double> stack = new Stack<double>();
            foreach (var token in tokens)
            {
                double? value = GetDouble(token);
                if (value.HasValue)
                {
                    stack.Push(value.Value);
                }
                else
                {
                    double val1 = stack.Pop();
                    double val2 = stack.Pop();
                    double result = Compute(val1, val2, token);
                    stack.Push(result);
                }
            }

            Console.WriteLine("Wynik: " + stack.Pop());
        }

        static double? GetDouble(string token)
        {
            double result;
            if (double.TryParse(token, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        private static double Compute(double x, double y, string oper)
        {
            switch (oper)
            {
                case "+":
                    return Add(x, y);
                case "-":
                    return Sub(x, y);
                case "*":
                    return Mul(x, y);
                case "/":
                    return Div(x, y);
                case "%":
                    return Mod(x, y);
                case "&":
                    return And(x, y);
                case "|":
                    return Or(x, y);
                case "^":
                    return Xor(x, y);
                default:
                    throw new ArgumentException("Niepoprawny operator");
            }
        }

        private static double Add(double x, double y)
        {
            return x + y;
        }

        private static double Sub(double x, double y)
        {
            return x - y;
        }

        private static double Mul(double x, double y)
        {
            return x * y;
        }

        private static double Div(double x, double y)
        {
            return x / y;
        }

        private static double Mod(double x, double y)
        {
            return x % y;
        }

        private static double And(double x, double y)
        {
            return (int)x & (int)y;
        }

        private static double Or(double x, double y)
        {
            return (int)x | (int)y;
        }

        private static double Xor(double x, double y)
        {
            return (int)x ^ (int)y;
        }
    }
}
