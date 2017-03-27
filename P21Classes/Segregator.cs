using System.Collections.Generic;
using System.Linq;

namespace P21Classes
{
    class Segregator
    {
        private Dictionary<string, Category> _categories = new Dictionary<string, Category>();
        private Dictionary<int, File> _fileIndex = new Dictionary<int, File>();

        public List<Category> Categories => _categories.Select(x => x.Value).ToList();

        public int AddFile(string categoryName, File file)
        {
            Category category;
            if (!_categories.ContainsKey(categoryName))
            {
                category = new Category(categoryName);
                _categories.Add(categoryName, category);
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
                bool isAnyFileInCategory = _categories[file.CategoryName].DeleteFile(file);
                if (!isAnyFileInCategory)
                {
                    _categories.Remove(file.CategoryName);
                }
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

        public List<File> GetFilesFromCategory(string categoryName)
        {
            if (_categories.ContainsKey(categoryName))
            {
                return _categories[categoryName].Files;
            }
            else
            {
                return new List<File>();
            }
        }
    }
}
