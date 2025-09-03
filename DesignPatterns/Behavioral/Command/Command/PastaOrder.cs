using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Concrete Commands
namespace DesignPatterns.Behavioral.Command.Command
{
    internal class PastaOrder : IOrder
    {
        private Chef _chef;
        public PastaOrder(Chef chef) => _chef = chef;
        public void Execute() => _chef.CookPasta();
    }
}
