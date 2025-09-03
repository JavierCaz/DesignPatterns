using DesignPatterns.Structural.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File = DesignPatterns.Behavioral.Visitor.Element.File;
using Folder = DesignPatterns.Behavioral.Visitor.Element.Folder;

namespace DesignPatterns.Behavioral.Visitor.Visitor
{
    internal interface IFileSystemVisitor
    {
        void VisitFile(File file);
        void VisitFolder(Folder folder);

    }
}
