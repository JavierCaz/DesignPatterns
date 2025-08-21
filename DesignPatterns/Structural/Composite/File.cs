using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Leaf
namespace DesignPatterns.Structural.Composite
{
    internal class File : IFileSystemItem
    {

        private string name;

        public File(string name)
        {
            this.name = name;
        }

        public void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + "- File: " + name);
        }

    }
}
