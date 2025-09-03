using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator.Iterator
{
    internal class ForwardIterator : IExhibitIterator
    {
        private List<string> _exhibits;
        private int _position = 0;

        public ForwardIterator(List<string> exhibits) => _exhibits = exhibits;

        public bool HasNext() => _position < _exhibits.Count;
        public string Next() => HasNext() ? _exhibits[_position++] : null;

    }
}
