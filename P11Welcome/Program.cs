using System;

namespace P11Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (args[0])
            {
                case "0":
                    Main0();
                    break;
                case "1":
                    Main1();
                    break;
                case "2":
                    Main2();
                    break;
                case "3":
                    Main3();
                    break;
                default:
                    ExampleMain();
                    break;
            }
        }

        static void ExampleMain()
        {
            Console.WriteLine("Hello world!");
        }

        static void Main0()
        {
            Console.WriteLine("****************");
            Console.WriteLine("* Hello world! *");
            Console.WriteLine("****************");
        }

        static void Main1()
        {
            Console.Write("Podaj znak ramki: ");
            string inputForFrame = Console.ReadLine();

            char frameChar = inputForFrame[0];

            Console.WriteLine(new string(frameChar, 16));
            Console.WriteLine(frameChar + " Hello world! " + frameChar);
            Console.WriteLine(new string(frameChar, 16));
        }

        static void Main2()
        {
            Console.Write("Podaj tekst: ");
            string displayedText = Console.ReadLine();
            Console.Write("Podaj znak ramki: ");
            string inputForFrame = Console.ReadLine();

            char frameChar = inputForFrame[0];

            Console.WriteLine(new string(frameChar, displayedText.Length + 4));
            Console.WriteLine(frameChar + " " + displayedText + " " + frameChar);
            Console.WriteLine(new string(frameChar, displayedText.Length + 4));
        }

        static void Main3()
        {
            Console.Write("Podaj tekst: ");
            string displayedText = Console.ReadLine();
            Console.Write("Podaj znak ramki: ");
            string inputForFrame = Console.ReadLine();

            char frameChar = inputForFrame[0];
            var frame = new string(frameChar, displayedText.Length + 4);

            Console.WriteLine("{0}\n{1} {2} {1}\n{0}", frame, frameChar, displayedText);
        }
    }
}
