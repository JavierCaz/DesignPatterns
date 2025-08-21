using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Composite
namespace DesignPatterns.Structural.Composite
{
    internal class Folder : IFileSystemItem
    {

        private string name;
        private List<IFileSystemItem> items = new List<IFileSystemItem>();

        public Folder(string name)
        {
            this.name = name;
        }

        public void Add(IFileSystemItem item)
        {
            items.Add(item);
        }

        public void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + "+ Folder: " + name);
            foreach (var item in items)
            {
                item.Display(indent + 2);
            }
        }

    }
}
