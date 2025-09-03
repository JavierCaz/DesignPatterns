using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State.State
{
    internal class ReviewState : IDocumentState
    {
        public void Handle(Document context)
        {
            Console.WriteLine("Document is under Review. Moving to Approved.");
            context.SetState(new ApprovedState());
        }

    }
}
