using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File = DesignPatterns.Behavioral.Visitor.Element.File;
using Folder = DesignPatterns.Behavioral.Visitor.Element.Folder;

namespace DesignPatterns.Behavioral.Visitor.Visitor
{
    internal class SizeCalculatorVisitor : IFileSystemVisitor
    {
        public int TotalSize { get; private set; } = 0;

        public void VisitFile(File file)
        {
            TotalSize += file.Size;
            Console.WriteLine($"File: {file.Name}, Size: {file.Size}KB");
        }

        public void VisitFolder(Folder folder)
        {
            Console.WriteLine($"Folder: {folder.Name}");
        }

    }
}
