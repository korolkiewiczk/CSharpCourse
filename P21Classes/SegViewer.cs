using System;
using System.Linq;

namespace P21Classes
{
    class SegViewer
    {
        private Segregator _segregator;

        public SegViewer(Segregator segregator)
        {
            _segregator = segregator;
        }

        public void ShowCategory(string categoryName)
        {
            var showedOutput = GetCategoryContentAsString(categoryName);
            Console.WriteLine(showedOutput);
        }

        public void ShowAll()
        {
            foreach (var category in _segregator.Categories.OrderBy(x => x.Name))
            {
                Console.WriteLine($"Category [{category.Name}]:");
                Console.Write(GetCategoryContentAsString(category.Name));
                Console.WriteLine();
            }
        }

        private string GetCategoryContentAsString(string categoryName)
        {
            var files = _segregator.GetFilesFromCategory(categoryName);
            return string.Join("\r\n", files);
        }
    }
}
