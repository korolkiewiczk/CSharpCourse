using System;

namespace P13Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) { ExampleMain(); return; }
            switch (args[0])
            {
                case "1":
                    Calculator0.Entry();
                    break;
                case "2":
                    Calculator1.Entry();
                    break;
                case "3":
                    Calculator2.Entry();
                    break;
                case "4":
                    Calculator3.Entry();
                    break;
                case "++":
                    PPMMOperatorsExample.Example();
                    break;
                default:
                    ExampleMain();
                    break;
            }
        }

        static void ExampleMain()
        {
            string text = Console.ReadLine();

            var countUpperLetters = CountUpperLetters(text);
            var countLowerLetters = CountLowerLetters(text);
            if (countUpperLetters + countLowerLetters == text.Length)
            {
                Console.WriteLine("{0} {1}", countUpperLetters, countLowerLetters);
            }
            else
            {
                Console.WriteLine(nameof(countUpperLetters) + "!=" +nameof(countLowerLetters));
            }
        }

        static int CountUpperLetters(string text)
        {
            int numberOfUpperLetters = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))  //operator this[]
                {
                    numberOfUpperLetters++;
                }
            }
            return numberOfUpperLetters;
        }

        static int CountLowerLetters(string text)
        {
            return text.Length - CountUpperLetters(text) - CountNotLetters(text);
        }

        static int CountNotLetters(string text)
        {
            int numberOfNonLetters = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetter(text[i]))  //operator this[]
                {
                    numberOfNonLetters++;
                }
            }
            return numberOfNonLetters;
        }
    }
}
