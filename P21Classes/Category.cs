using System.Collections.Generic;

namespace P21Classes
{
    class Category
    {
        private List<File> _files = new List<File>();

        public string Name { get; set; }

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

        public void DeleteFile(File file)
        {
            _files.Remove(file);
        }
    }
}
