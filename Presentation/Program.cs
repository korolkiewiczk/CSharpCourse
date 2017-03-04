using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    class Program
    {
        private const int DisplayDelay = 20;

        static void Main(string[] args)
        {
            IScreen[] screens = new IScreen[] { new Screen1(), new Screen2() };
            Console.ReadKey();
            for (int i = 0; i < screens.Length; i++)
            {
                IScreen currentScreen = screens[i];
                ShowScreen(currentScreen);
                do
                {
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    else if (key.Key == ConsoleKey.Escape && i > 0)
                    {
                        i -= 2;
                    }
                } while (true);
            }
        }

        static void ShowScreen(IScreen screen)
        {
            switch (screen.Method)
            {
                case DisplayMethod.All:
                    ShowWholeScreen(screen.Text);
                    break;
                case DisplayMethod.LineByLine:
                    ShowScreenLineByLine(screen.Text);
                    break;
                case DisplayMethod.CharByChar:
                    ShowScreenCharByChar(screen.Text);
                    break;
            }
        }

        static void ShowWholeScreen(string text)
        {
            Console.Clear();
            Console.Write(text);
        }

        static void ShowScreenLineByLine(string text)
        {
            Console.Clear();
            foreach (string line in text.Split('\n'))
            {
                Console.Write(line);
                Console.WriteLine();
                System.Threading.Thread.Sleep(DisplayDelay);
            }
        }

        static void ShowScreenCharByChar(string text)
        {
            Console.Clear();
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(DisplayDelay);
            }
        }
    }
}
