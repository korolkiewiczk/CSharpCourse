using System;
using System.Collections.Generic;

namespace P13Functions
{
    class Calculator3
    {
        public static void Entry()
        {
            Console.WriteLine("Podaj wyrażenie: ");
            string expression = Console.ReadLine();
            string[] tokens = expression.Split(' ');
            Stack<string> stack = new Stack<string>();
            foreach (var token in tokens)
            {
                if (IsOperator(token))
                {
                    string val1 = stack.Pop();

                    if (GetNumOfArgs(token) == 2)
                    {
                        string val2 = stack.Pop();
                        stack.Push(Compute2Args(val1, val2, token));
                    }
                    else
                    {
                        stack.Push(Compute1Arg(val1, token));
                    }
                }
                else
                {
                    stack.Push(token);
                }

                Console.WriteLine(string.Join(" ", stack.ToArray()));
            }

            Console.WriteLine("Wynik: " + stack.Pop());
        }

        static bool IsOperator(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/";
        }

        static int GetNumOfArgs(string token)
        {
            if (token == "+")
                return 2;
            else
                return 1;
        }

        private static string Compute2Args(string x, string y, string oper)
        {
            switch (oper)
            {
                case "+":
                    return Concat(x, y);
                default:
                    throw new ArgumentException("Nieprawidłowy operator 2 parametrowy");
            }
        }

        private static string Compute1Arg(string x, string oper)
        {
            switch (oper)
            {
                case "-":
                    return RemoveLastChar(x);
                case "*":
                    return StringMul2(x);
                case "/":
                    return StringDiv2(x);
                default:
                    throw new ArgumentException("Nieprawidłowy operator 1 parametrowy");
            }
        }

        private static string Concat(string x, string y)
        {
            return x + y;
        }

        private static string RemoveLastChar(string x)
        {
            return x.Substring(0, x.Length - 1);
        }

        private static string StringMul2(string x)
        {
            return x + x;
        }

        private static string StringDiv2(string x)
        {
            return x.Substring(0, x.Length / 2);
        }
    }
}
