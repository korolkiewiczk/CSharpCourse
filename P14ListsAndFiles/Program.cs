using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace P14ListsAndFiles
{
    class Program
    {
        static List<string> _buffer = new List<string>();

        private static readonly Dictionary<string, Func<string[], string>>
            _functions = new Dictionary<string, Func<string[], string>>
            {
                {"list-all", ListAll},
                {"search", Find },
                {"clear", Clear },
                {"save", Save }
            };


        static void Main(string[] args)
        {
            ShowInfo();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "#exit") break;
                if (line.Length > 0 && line[0] == '#' && (line.Length == 1 || line[1] != '#'))
                {
                    try
                    {
                        var tokens = line.Substring(1).Split(' ');
                        Console.WriteLine(ExecuteCommand(tokens[0], tokens.Skip(1).ToArray()));
                    }
                    catch
                    {
                        Console.WriteLine("Invalid command input.");
                    }
                }
                else
                {
                    _buffer.Add(line);
                }
            }
        }

        private static void ShowInfo()
        {
            Console.WriteLine("Notepad, available commands:");
            Console.WriteLine(string.Join(", ", _functions.Select(x => "#" + x.Key)));
        }

        private static string ExecuteCommand(string commandName, params string[] args)
        {
            if (!_functions.ContainsKey(commandName))
            {
                return "Command not found.";
            }
            return _functions[commandName](args);
        }

        private static string ListAll(params string[] args)
        {
            return string.Join("\r\n", _buffer);
        }

        private static string Find(params string[] args)
        {
            var toFind = args[0].ToLower();
            var output = _buffer
                .Select((x, i) => new { item = x, index = i })
                .Where(x => x.item.ToLower().Contains(toFind))
                .Select(x => $"Line {x.index}:{x.item}").ToArray();

            if (output.Length == 0)
            {
                return "Not found.";
            }

            return string.Join("\r\n", output);
        }

        private static string Clear(params string[] args)
        {
            _buffer.Clear();
            return "Buffer cleared";
        }

        private static string Save(params string[] args)
        {
            File.WriteAllLines(args[0], _buffer);
            return $"File {args[0]} saved.";
        }
    }
}
