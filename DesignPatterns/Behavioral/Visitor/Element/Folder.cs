using DesignPatterns.Behavioral.Visitor.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Element
{
    internal class Folder : IFileSystemElement
    {
        public string Name { get; }
        public List<IFileSystemElement> Children { get; } = new();

        public Folder(string name) => Name = name;

        public void Add(IFileSystemElement element) => Children.Add(element);

        public void Accept(IFileSystemVisitor visitor)
        {
            visitor.VisitFolder(this);
            foreach (var child in Children)
            {
                child.Accept(visitor);
            }
        }

    }
}
