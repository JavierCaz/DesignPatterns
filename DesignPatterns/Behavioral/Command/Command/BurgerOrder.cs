using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Concrete Commands
namespace DesignPatterns.Behavioral.Command.Command
{
    internal class BurgerOrder : IOrder
    {
        private Chef _chef;
        public BurgerOrder(Chef chef) => _chef = chef;
        public void Execute() => _chef.CookBurger();
    }
}
