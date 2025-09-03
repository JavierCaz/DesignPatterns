using DesignPatterns.Behavioral.State.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Context
namespace DesignPatterns.Behavioral.State
{
    internal class Document
    {
        private IDocumentState _state;

        public Document() => _state = new DraftState();

        public void SetState(IDocumentState state) => _state = state;

        public void Request() => _state.Handle(this);

    }
}
