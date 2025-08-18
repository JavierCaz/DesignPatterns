using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.AbstractFactory.Products;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod.Creators;
using DesignPatterns.Creational.FactoryMethod.Products;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;

//Factory Method
DocumentCreator creator = new PdfDocumentCreator();
IDocument doc = creator.CreateDocument();
doc.Print();

//Abstract Factory
IUIFactory factory = new DarkUIFactory();
IButton button = factory.CreateButton();
ICheckbox checkbox = factory.CreateCheckbox();

button.Render();
checkbox.Render();

//Builder
var builder = new SportsCarBuilder();
var director = new CarDirector();

director.ConstructSportsCar(builder);
Car car = builder.Build();
car.ShowSpecs();

//Prototype
IShape original = new Circle { Radius = 10 };
IShape copy = original.Clone();

original.Draw();
copy.Draw();

//Singleton
Logger.Instance.Log("Application started");
Logger.Instance.Log("Another log entry");
