using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.AbstractFactory.Products;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod.Creators;
using DesignPatterns.Creational.FactoryMethod.Products;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge.Abstraction;
using DesignPatterns.Structural.Bridge.Implementor;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator.Component;
using DesignPatterns.Structural.Decorator.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.Proxy;

//Creational Patterns

////Factory Method
//DocumentCreator creator = new PdfDocumentCreator();
//IDocument doc = creator.CreateDocument();
//doc.Print();

////Abstract Factory
//IUIFactory factory = new DarkUIFactory();
//IButton button = factory.CreateButton();
//ICheckbox checkbox = factory.CreateCheckbox();

//button.Render();
//checkbox.Render();

////Builder
//var builder = new SportsCarBuilder();
//var director = new CarDirector();

//director.ConstructSportsCar(builder);
//Car car = builder.Build();
//car.ShowSpecs();

////Prototype
//DesignPatterns.Creational.Prototype.IShape original = new Circle { Radius = 10 };
//DesignPatterns.Creational.Prototype.IShape copy = original.Clone();

//original.Draw();
//copy.Draw();

////Singleton
//Logger.Instance.Log("Application started");
//Logger.Instance.Log("Another log entry");


//Structural Patterns

//Adapter
DesignPatterns.Structural.Adapter.IShape shape = new TextShape(new TextView());
shape.Draw();

//Bridge
Message msg1 = new RegularMessage(new EmailSender());
msg1.Send("Meeting Reminder", "Don't forget the meeting at 10 AM.");

Message msg2 = new UrgentMessage(new SMSSender());
msg2.Send("Server Down", "Please check the server immediately!");

//Composite
Folder root = new Folder("Root");
root.Add(new DesignPatterns.Structural.Composite.File("file1.txt"));
root.Add(new DesignPatterns.Structural.Composite.File("file2.txt"));

Folder subFolder = new Folder("SubFolder");
subFolder.Add(new DesignPatterns.Structural.Composite.File("file3.txt"));
subFolder.Add(new DesignPatterns.Structural.Composite.File("file4.txt"));

root.Add(subFolder);

root.Display();

//Decorator
INotifier notifier = new BasicNotifier();

notifier = new EncryptedNotifier(notifier);
notifier = new PriorityNotifier(notifier);

notifier.Send("System update required.");

//Facade
var homeFacade = new HomeAutomationFacade();

homeFacade.LeaveHome();
Console.WriteLine();
homeFacade.ArriveHome();


//Flyweight
var factory = new CharacterFactory();

string text = "HI😊";
string font = "Arial";
int size = 12;

for (int i = 0; i < text.Length; i++)
{
    char c = text[i];

    if (char.IsLetter(c))
    {
        ICharacter sharedChar = factory.GetCharacter(c, font, size);
        sharedChar.Display($"position {i}");
    }
    else
    {
        ICharacter specialChar = new SpecialCharacter(c.ToString(), "emoji");
        specialChar.Display($"position {i}");
    }
}

//Proxy
IImage image1 = new ImageProxy("photo1.jpg");
IImage image2 = new ImageProxy("photo2.jpg");

Console.WriteLine("Images created, but not loaded yet.");

image1.Display();
image2.Display();
