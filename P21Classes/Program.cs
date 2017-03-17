using System;

namespace P21Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input some text: ");
            var helloWorld = new HelloWorld(Console.ReadLine());
            helloWorld.ShowMe();
            helloWorld.WaitForExitKey();
        }
    }
}
