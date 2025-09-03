using DesignPatterns.Behavioral.Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Aggregate Interface
namespace DesignPatterns.Behavioral.Iterator.Aggregate
{
    internal interface IMuseum
    {
        IExhibitIterator CreateIterator();
        IExhibitIterator CreateReverseIterator();
    }
}
