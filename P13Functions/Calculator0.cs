using System;

namespace P13Functions
{
    class Calculator0
    {
        public static void Entry()
        {
            Console.Write("Podaj liczbę x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę y:");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Podaj operator/funkcję (jedną z +,-,*,/,%,&,|,^,POW,SIN,COS):");
            string oper = Console.ReadLine();
            Console.WriteLine("Wynik działania: " + Compute(x, y, oper)); //tu także mamy operator konkatenacji stringów
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
                case "POW":
                    return Pow(x, y);
                case "SIN":
                    return Sin(x);
                case "COS":
                    return Cos(x);
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

        private static double Pow(double x, double y)
        {
            return Math.Pow(x, y);
        }

        private static double Sin(double x)
        {
            return Math.Sin(x);
        }

        private static double Cos(double x)
        {
            return Math.Cos(x);
        }

    }
}
