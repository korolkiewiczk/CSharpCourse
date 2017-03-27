using System;

namespace P21Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length>0 && args[0]=="-hello-world")
                RunHelloWorld();

            RunSegregator();
        }

        private static void RunSegregator()
        {
            Segregator segregator=new Segregator();
            SegViewer viewer=new SegViewer(segregator);
            SegParser parser=new SegParser(segregator,viewer);
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "q" || line == "Q")
                    break;

                parser.ParseCommand(line);
            }
        }

        private static void RunHelloWorld()
        {
            Console.WriteLine("Input some text: ");
            var helloWorld = new HelloWorld(Console.ReadLine());
            helloWorld.ShowMe();
            helloWorld.WaitForExitKey();
        }
    }
}
