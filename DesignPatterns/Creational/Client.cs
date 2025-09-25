using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.AbstractFactory.Products;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod.Creators;
using DesignPatterns.Creational.FactoryMethod.Products;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    internal class CreationalClient
    {
        public void FactoryMethod()
        {
            Department dept = new HRDepartment();
            IEmployee employee = dept.HireEmployee();
            employee.DescribeRole();
        }

        public void AbstractFactory()
        {
            IUIFactory factory = new DarkUIFactory();
            IButton button = factory.CreateButton();
            ICheckbox checkbox = factory.CreateCheckbox();

            button.Render();
            checkbox.Render();
        }

        public void Builder()
        {
            var builder = new SportsCarBuilder();
            var director = new CarDirector();

            director.ConstructSportsCar(builder);
            Car car = builder.Build();
            car.ShowSpecs();
        }

        public void Prototype()
        {
            IShape original = new Circle { Radius = 10 };
            IShape copy = original.Clone();

            original.Draw();
            copy.Draw();
        }

        public void Singleton()
        {
            AirTrafficControlTower.Instance.Coordinate("Flight 123");
        }
    }
}
