using DesignPatterns.Creational.FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Creator
namespace DesignPatterns.Creational.FactoryMethod.Creators
{
    internal abstract class Department
    {
        public abstract IEmployee HireEmployee();
    }
}
