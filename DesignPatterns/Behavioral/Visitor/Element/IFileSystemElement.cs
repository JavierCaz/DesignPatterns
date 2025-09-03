using DesignPatterns.Behavioral.Visitor.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Element
{
    internal interface IFileSystemElement
    {
        void Accept(IFileSystemVisitor visitor);
    }
}
