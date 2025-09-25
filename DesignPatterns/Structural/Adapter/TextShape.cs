using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Adapter
namespace DesignPatterns.Structural.Adapter
{
    internal class TextShape : IShape
    {

        private readonly TextView _text;

        public TextShape(TextView text)
        {
            _text = text;
        }

        public void Draw()
        {
            _text.DrawText();
        }

    }
}
