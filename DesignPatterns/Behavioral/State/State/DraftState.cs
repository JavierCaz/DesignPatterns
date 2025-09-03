using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State.State
{
    internal class DraftState : IDocumentState
    {
        public void Handle(Document context)
        {
            Console.WriteLine("Document is in Draft. Moving to Review.");
            context.SetState(new ReviewState());
        }

    }
}
