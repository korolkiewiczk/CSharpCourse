using System;
using System.Text;

namespace P12Conditionals
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

        private static void Main0()
        {
            Console.WriteLine("Podaj x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj y:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj tekst:");
            Console.WriteLine(new string('x', x + y));
            string text = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                text = text.Substring(x, y) + text.Substring(0, x);
            }
            Console.WriteLine(text);
        }

        private static void Main1()
        {
            Console.WriteLine("Podaj x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj y:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj tekst:");
            Console.WriteLine(new string('x', x + y));
            string text = Console.ReadLine();
            string originalText = text;
            do
            {
                text = text.Substring(x, y) + text.Substring(0, x);
                Console.WriteLine(text);
            } while (originalText != text);
        }

        private static void Main2()
        {
            Console.WriteLine("Podaj x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj y:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj tekst:");
            Console.WriteLine(new string('x', x + y));
            string text = Console.ReadLine();

            bool isUpperLetterInText = false;

            foreach (var character in text)
            {
                if (char.IsUpper(character))
                {
                    isUpperLetterInText = true;
                    break;
                }
            }

            string originalText = text;
            do
            {
                text = text.Substring(x, y) + text.Substring(0, x);
                if (!isUpperLetterInText || char.IsUpper(text[0]))
                    Console.WriteLine(text);
            } while (originalText != text);
        }

        private static void Main3()
        {
            Console.WriteLine("Podaj x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj y:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj tekst:");
            Console.WriteLine(new string('x', x + y));
            string text = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                text = text.Substring(x, y) + text.Substring(0, x);
            }

            StringBuilder sb = new StringBuilder();

            foreach (var character in text)
            {
                char newCharacter;
                switch (character)
                {
                    case 'a':
                        newCharacter = 'b';
                        break;
                    case 'A':
                        newCharacter = 'B';
                        break;
                    case 'e':
                        newCharacter = 'f';
                        break;
                    case 'E':
                        newCharacter = 'F';
                        break;
                    case 'i':
                        newCharacter = 'j';
                        break;
                    case 'I':
                        newCharacter = 'J';
                        break;
                    case 'o':
                        newCharacter = 'p';
                        break;
                    case 'O':
                        newCharacter = 'P';
                        break;
                    case 'u':
                        newCharacter = 'v';
                        break;
                    case 'U':
                        newCharacter = 'V';
                        break;
                    case 'y':
                        newCharacter = 'z';
                        break;
                    case 'Y':
                        newCharacter = 'Z';
                        break;
                    default:
                        newCharacter = character;
                        break;
                }

                sb.Append(newCharacter);
            }

            Console.WriteLine(sb);
        }

        private static void ExampleMain()
        {
            bool exit = false;
            while (!exit)
            {
                string input = Console.ReadLine();
                if (input.Length > 10)
                    continue;

                if (input != "exit")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        Console.WriteLine(input);
                    }
                }
                else
                {
                    exit = true;
                }
            }
        }
    }
}
