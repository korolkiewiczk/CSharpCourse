using System;
using System.Collections.Generic;
using System.Linq;

namespace P21Classes
{
    class SegParser
    {
        private readonly Dictionary<string, Action<string[]>> _commands;
        private readonly SegCommands _segCommands;

        public SegParser(Segregator segregator, SegViewer viewer)
        {
            _segCommands = new SegCommands(segregator, viewer);
            _commands = new Dictionary<string, Action<string[]>>()
            {
                {"+", _segCommands.AddFile},
                {"-", _segCommands.RemoveFile },
                {"#", _segCommands.ShowFiles }
            };
        }

        public void ParseCommand(string input)
        {
            string[] tokens = input.Split();
            string cmd = tokens[0];
            InvokeCommand(cmd, tokens.Skip(1).ToArray());
        }

        private void InvokeCommand(string cmd, string[] parameters)
        {
            try
            {
                _commands[cmd](parameters);
            }
            catch
            {
                Console.WriteLine("Invalid command");
            }
        }
    }
}
