using System;

namespace P21Classes
{
    class SegCommands
    {
        private readonly Segregator _segregator;
        private readonly SegViewer _viewer;

        public SegCommands(Segregator segregator, SegViewer viewer)
        {
            _segregator = segregator;
            _viewer = viewer;
        }

        public void AddFile(string[] parameters)
        {
            int id = _segregator.AddFile(parameters[0].ToUpper(), new File(parameters[1]));
            Console.WriteLine(id);
        }

        public void RemoveFile(string[] parameters)
        {
            if (_segregator.DeleteFile(Convert.ToInt32(parameters[0])))
            {
                Console.WriteLine("Removed");
            }
            else
            {
                Console.WriteLine("No file found");
            }
        }

        public void ShowFiles(string[] parameters)
        {
            if (parameters.Length == 1)
            {
                _viewer.ShowCategory(parameters[0].ToUpper());
            }
            else
            {
                _viewer.ShowAll();
            }
            Console.WriteLine("-----------");
        }
    }
}