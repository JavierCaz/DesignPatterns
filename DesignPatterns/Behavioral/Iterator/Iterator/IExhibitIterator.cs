using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Iterator Interface
namespace DesignPatterns.Behavioral.Iterator.Iterator
{
    internal interface IExhibitIterator
    {
        bool HasNext();
        string Next();

    }
}
