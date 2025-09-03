using DesignPatterns.Behavioral.ChainOfResposibility;
using DesignPatterns.Behavioral.Command.Command;
using DesignPatterns.Behavioral.Command;
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
using DesignPatterns.Behavioral.Interpreter.Expression;
using DesignPatterns.Behavioral.Interpreter;
using DesignPatterns.Behavioral.Iterator.Aggregate;
using DesignPatterns.Behavioral.Mediator.Colleague;
using DesignPatterns.Behavioral.Mediator.Mediator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer.Subject;
using DesignPatterns.Behavioral.Observer.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy.Strategy;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Visitor.Visitor;
using File = DesignPatterns.Behavioral.Visitor.Element.File;
using Folder = DesignPatterns.Behavioral.Visitor.Element.Folder;

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

////Adapter
//DesignPatterns.Structural.Adapter.IShape shape = new TextShape(new TextView());
//shape.Draw();

////Bridge
//Message msg1 = new RegularMessage(new EmailSender());
//msg1.Send("Meeting Reminder", "Don't forget the meeting at 10 AM.");

//Message msg2 = new UrgentMessage(new SMSSender());
//msg2.Send("Server Down", "Please check the server immediately!");

////Composite
//Folder root = new Folder("Root");
//root.Add(new DesignPatterns.Structural.Composite.File("file1.txt"));
//root.Add(new DesignPatterns.Structural.Composite.File("file2.txt"));

//Folder subFolder = new Folder("SubFolder");
//subFolder.Add(new DesignPatterns.Structural.Composite.File("file3.txt"));
//subFolder.Add(new DesignPatterns.Structural.Composite.File("file4.txt"));

//root.Add(subFolder);

//root.Display();

////Decorator
//INotifier notifier = new BasicNotifier();

//notifier = new EncryptedNotifier(notifier);
//notifier = new PriorityNotifier(notifier);

//notifier.Send("System update required.");

////Facade
//var homeFacade = new HomeAutomationFacade();

//homeFacade.LeaveHome();
//Console.WriteLine();
//homeFacade.ArriveHome();


////Flyweight
//var factory = new CharacterFactory();

//string text = "HI😊";
//string font = "Arial";
//int size = 12;

//for (int i = 0; i < text.Length; i++)
//{
//    char c = text[i];

//    if (char.IsLetter(c))
//    {
//        ICharacter sharedChar = factory.GetCharacter(c, font, size);
//        sharedChar.Display($"position {i}");
//    }
//    else
//    {
//        ICharacter specialChar = new SpecialCharacter(c.ToString(), "emoji");
//        specialChar.Display($"position {i}");
//    }
//}

////Proxy
//IImage image1 = new ImageProxy("photo1.jpg");
//IImage image2 = new ImageProxy("photo2.jpg");

//Console.WriteLine("Images created, but not loaded yet.");

//image1.Display();
//image2.Display();

//Behavioral Patterns

//Chain of Resposibility
var lead = new TeamLead();
var manager = new Manager();
var director = new Director();

lead.SetNext(manager);
manager.SetNext(director);

lead.HandleExpense(50);     // Handled by Team Lead
lead.HandleExpense(500);    // Handled by Manager
lead.HandleExpense(5000);   // Handled by Director
lead.HandleExpense(15000);  // Not handled

//Command
var chef = new Chef();

var burgerOrder = new BurgerOrder(chef);
var pastaOrder = new PastaOrder(chef);

var waiter = new Waiter();

waiter.TakeOrder(burgerOrder);
waiter.PlaceOrder();

waiter.TakeOrder(pastaOrder);
waiter.PlaceOrder();

//Interpreter
var context = new Context();
context.SetVariable("x", 10);
context.SetVariable("y", 4);

// Represents: x + y - 2
IExpression expression = new SubtractExpression(
    new AddExpression(
        new VariableExpression("x"),
        new VariableExpression("y")
    ),
    new NumberExpression(2)
);

Console.WriteLine("Result: " + expression.Interpret(context));

//Iterator
var museum = new Museum();
museum.AddExhibit("Ancient Egypt");
museum.AddExhibit("Renaissance Art");
museum.AddExhibit("Modern Sculpture");

Console.WriteLine("Forward Tour:");
var forward = museum.CreateIterator();
while (forward.HasNext())
{
    Console.WriteLine("Viewing: " + forward.Next());
}

Console.WriteLine("\nReverse Tour:");
var reverse = museum.CreateReverseIterator();
while (reverse.HasNext())
{
    Console.WriteLine("Viewing: " + reverse.Next());
}

//Mediator
var chatRoom = new ChatRoom();

var alice = new ChatUser("Alice");
var bob = new ChatUser("Bob");
var charlie = new ChatUser("Charlie");

chatRoom.Register(alice);
chatRoom.Register(bob);
chatRoom.Register(charlie);

alice.Send("Hello everyone!");
bob.Send("Hi Alice!");

//Memento
var editor = new TextEditor();
var history = new History();

editor.Type("Hello");
history.Backup(editor);

editor.Type(" World");
history.Backup(editor);

editor.Type("!");

Console.WriteLine("Current content: " + editor.GetContent());

history.Undo(editor);
Console.WriteLine("After undo: " + editor.GetContent());

history.Undo(editor);
Console.WriteLine("After second undo: " + editor.GetContent());

//Observer
var station = new WeatherStation();

var phone = new Phone();
var computer = new Computer();

station.Attach(phone);
station.Attach(computer);

station.SetTemperature(22.5f);
station.SetTemperature(25.0f);

//State
var doc = new Document();

doc.Request();
doc.Request();
doc.Request();

//Strategy
var processor = new PaymentProcessor(new CreditCardPayment());
processor.ProcessPayment(100.00m);

processor.SetStrategy(new PayPalPayment());
processor.ProcessPayment(250.00m);

processor.SetStrategy(new BankTransferPayment());
processor.ProcessPayment(500.00m);

//Template Method
DataExporter csv = new CsvExporter();
csv.Export();

Console.WriteLine();

DataExporter json = new JsonExporter();
json.Export();

//Visitor
var root = new Folder("Root");
root.Add(new File("Resume.pdf", 120));
root.Add(new File("Photo.jpg", 300));

var subFolder = new Folder("Projects");
subFolder.Add(new File("Project1.docx", 200));
subFolder.Add(new File("Project2.pptx", 450));

root.Add(subFolder);

var visitor = new SizeCalculatorVisitor();
root.Accept(visitor);

Console.WriteLine($"Total Size: {visitor.TotalSize}KB");
