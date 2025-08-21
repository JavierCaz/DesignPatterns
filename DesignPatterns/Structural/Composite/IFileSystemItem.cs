using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Component
namespace DesignPatterns.Structural.Composite
{
    internal interface IFileSystemItem
    {
        void Display(int indent = 0);
    }
}
