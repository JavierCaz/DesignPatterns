using DesignPatterns.Behavioral.Visitor.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Element
{
    internal class File : IFileSystemElement
    {
        public string Name { get; }
        public int Size { get; }

        public File(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public void Accept(IFileSystemVisitor visitor) => visitor.VisitFile(this);

    }
}
