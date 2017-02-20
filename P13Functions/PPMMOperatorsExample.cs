using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13Functions
{
    class PPMMOperatorsExample
    {
        static int x, y;
        static void Log(string code)
        {
            Console.WriteLine($"{code}: {x}\t{y}");
        }
        public static void Example()
        {
            x = 0; y = 0;
            Console.WriteLine("Code   \t  x\ty");
            Log("Init:   ");
            x = ++y;
            Log("x = ++y;");
            x = y++;
            Log("x = y++;");
            x = --y;
            Log("x = --y;");
            x = y--;
            Log("x = y--;");
            Console.WriteLine(y++);
            Log("Console.WriteLine(y++);");
        }
    }
}
