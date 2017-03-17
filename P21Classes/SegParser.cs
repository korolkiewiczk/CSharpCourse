using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21Classes
{
    class SegParser
    {
        private Segregator _segregator;
        private SegViewer _viewer;

        public SegParser(Segregator segregator, SegViewer viewer)
        {
            _segregator = segregator;
            _viewer = viewer;
        }

        public void ParseCommand(string input)
        {
            string[] tokens = input.Split();
            string cmd = tokens[0];
            InvokeCommand(cmd, tokens.Skip(1).ToArray());
        }

        private void InvokeCommand(string cmd, string[] parameters)
        {
            switch (cmd)
            {
                case "+":
                    _segregator.AddFile(parameters[0], new File(parameters[1]));
                    break;
                case "-":
                    _segregator.DeleteFile(Convert.ToInt32(parameters[0]));
                    break;
            }
        }
    }
}
