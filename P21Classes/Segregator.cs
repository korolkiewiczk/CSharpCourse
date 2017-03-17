using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21Classes
{
    class Segregator
    {
        private Dictionary<string, Category> _categories = new Dictionary<string, Category>();
        private Dictionary<int, File> _fileIndex = new Dictionary<int, File>();

        public int AddFile(string categoryName, File file)
        {
            Category category;
            if (!_categories.ContainsKey(categoryName))
            {
                category = new Category(categoryName);
            }
            else
            {
                category = _categories[categoryName];
            }

            int id = category.AddFile(file);
            _fileIndex.Add(id, file);

            return id;
        }

        public bool DeleteFile(int id)
        {
            try
            {
                var file = GetFile(id);
                _fileIndex.Remove(id);
                _categories[file.Category.Name].DeleteFile(file);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public File GetFile(int id)
        {
            return _fileIndex[id];
        }
    }
}
