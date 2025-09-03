using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator.Iterator
{
    internal class ReverseIterator : IExhibitIterator
    {
        private List<string> _exhibits;
        private int _position;

        public ReverseIterator(List<string> exhibits)
        {
            _exhibits = exhibits;
            _position = exhibits.Count - 1;
        }

        public bool HasNext() => _position >= 0;
        public string Next() => HasNext() ? _exhibits[_position--] : null;

    }
}
