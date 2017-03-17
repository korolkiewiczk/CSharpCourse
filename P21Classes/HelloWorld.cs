using System;

namespace P21Classes
{
    class HelloWorld
    {
        public string Info { get; set; }

        public HelloWorld()
        {
            Info = "Nothing happen";
        }

        public HelloWorld(string newInfo)
        {
            Info = newInfo;
        }

        public void ShowMe()
        {
            Console.WriteLine($"I would say {Info}");
        }

        public void WaitForExitKey()
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Write("Do you want to exit? (Y/N): ");
                key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.N)
                {
                    ShowMe();
                }
                else 
                if (key.Key != ConsoleKey.Y)
                {
                    ShowBadInfo();
                }
            } while (key.Key != ConsoleKey.Y);
        }

        private void ShowBadInfo()
        {
            Console.WriteLine("You provided bad input. Try again.");
        }
    }
}
