using System.Collections.Generic;
using System.Linq;

namespace P21Classes
{
    class Category
    {
        private List<File> _files = new List<File>();

        public string Name { get; set; }

        public List<File> Files => _files;

        public Category(string name)
        {
            Name = name;
        }

        public int AddFile(File file)
        {
            _files.Add(file);
            file.Category = this;
            return file.Id;
        }

        /// <summary>
        /// Zwraca false jeśli kategoria nie zawiera już żadnego pliku
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public bool DeleteFile(File file)
        {
            _files.Remove(file);
            return _files.Any();
        }
    }
}
