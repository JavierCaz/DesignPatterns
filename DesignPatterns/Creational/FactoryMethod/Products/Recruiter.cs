using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Products
{
    internal class Recruiter : IEmployee
    {
        public void DescribeRole() => Console.WriteLine("I hire people.");
    }
}
