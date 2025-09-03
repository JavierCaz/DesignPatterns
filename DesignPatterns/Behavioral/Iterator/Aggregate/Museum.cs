using DesignPatterns.Behavioral.Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Concrete Aggregate
namespace DesignPatterns.Behavioral.Iterator.Aggregate
{
    internal class Museum : IMuseum
    {
        private List<string> _exhibits = new();

        public void AddExhibit(string exhibit) => _exhibits.Add(exhibit);

        public IExhibitIterator CreateIterator() => new ForwardIterator(_exhibits);
        public IExhibitIterator CreateReverseIterator() => new ReverseIterator(_exhibits);

    }
}
