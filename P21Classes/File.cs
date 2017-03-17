using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21Classes
{
    class File
    {
        private static int _globalId = 0;

        public int Id { get; }
        public string Text { get; private set; }
        public Category Category { get; set; }

        public File(string text)
        {
            Text = text;
            Id = _globalId++;
        }
    }
}
