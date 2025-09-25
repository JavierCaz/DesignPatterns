using DesignPatterns.Creational.FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Creators
{
    internal class EngineeringDepartment : Department
    {
        public override IEmployee HireEmployee() => new Developer();
    }
}
