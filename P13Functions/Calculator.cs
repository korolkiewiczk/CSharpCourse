using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13Functions
{
    class Calculator
    {
        public static void CalcMain()
        {
            double x, y;
            string oper;

            Console.WriteLine("Podaj x:");
            x = ReadDoubleValue();
            Console.WriteLine("Podaj y:");
            y = ReadDoubleValue();
            Console.WriteLine("Podaj operator/funkcję (jedną z +,-,*,/,%,&,|,^,POW,SIN,COS):");
            oper = Console.ReadLine();
            Console.WriteLine(Compute(x,y,oper));
        }

        private static double Compute(double d, double d1, string oper)
        {
            return 0.0;
        }

        private static double ReadDoubleValue()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
