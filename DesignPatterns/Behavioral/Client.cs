using DesignPatterns.Behavioral.ChainOfResposibility;
using DesignPatterns.Behavioral.Command.Command;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Interpreter.Expression;
using DesignPatterns.Behavioral.Interpreter;
using DesignPatterns.Behavioral.Iterator.Aggregate;
using DesignPatterns.Behavioral.Mediator.Colleague;
using DesignPatterns.Behavioral.Mediator.Mediator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer.Observer;
using DesignPatterns.Behavioral.Observer.Subject;
using DesignPatterns.Behavioral.Strategy.Strategy;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Visitor.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Visitor.Element;
using File = DesignPatterns.Behavioral.Visitor.Element.File;

namespace DesignPatterns.Behavioral
{
    internal class BehavioralClient
    {
        public void ChainOfResponsibilityPattern()
        {
            var lead = new TeamLead();
            var manager = new Manager();
            var director = new Director();

            lead.SetNext(manager);
            manager.SetNext(director);

            lead.HandleExpense(50);     // Handled by Team Lead
            lead.HandleExpense(500);    // Handled by Manager
            lead.HandleExpense(5000);   // Handled by Director
            lead.HandleExpense(15000);  // Not handled
        }

        public void CommandPattern()
        {
            var chef = new Chef();

            var burgerOrder = new BurgerOrder(chef);
            var pastaOrder = new PastaOrder(chef);

            var waiter = new Waiter();

            waiter.TakeOrder(burgerOrder);
            waiter.PlaceOrder();

            waiter.TakeOrder(pastaOrder);
            waiter.PlaceOrder();
        }

        public void InterpreterPattern()
        {
            var context = new Context();
            context.SetVariable("x", 10);
            context.SetVariable("y", 4);

            IExpression expression = new SubtractExpression(
                new AddExpression(
                    new VariableExpression("x"),
                    new VariableExpression("y")
                ),
                new NumberExpression(2)
            );

            Console.WriteLine("Result: " + expression.Interpret(context));
        }

        public void IteratorPattern()
        {
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
        }

        public void MediatorPattern()
        {
            var chatRoom = new ChatRoom();

            var alice = new ChatUser("Alice");
            var bob = new ChatUser("Bob");
            var charlie = new ChatUser("Charlie");

            chatRoom.Register(alice);
            chatRoom.Register(bob);
            chatRoom.Register(charlie);

            alice.Send("Hello everyone!");
            bob.Send("Hi Alice!");
        }

        public void MementoPattern()
        {
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
        }

        public void ObserverPattern()
        {
            var station = new WeatherStation();

            var phone = new Phone();
            var computer = new Computer();

            station.Attach(phone);
            station.Attach(computer);

            station.SetTemperature(22.5f);
            station.SetTemperature(25.0f);
        }

        public void StatePattern()
        {
            var doc = new Document();

            doc.Request();
            doc.Request();
            doc.Request();
        }

        public void StrategyPattern()
        {
            var processor = new PaymentProcessor(new CreditCardPayment());
            processor.ProcessPayment(100.00m);

            processor.SetStrategy(new PayPalPayment());
            processor.ProcessPayment(250.00m);

            processor.SetStrategy(new BankTransferPayment());
            processor.ProcessPayment(500.00m);
        }

        public void TemplateMethodPattern()
        {
            DataExporter csv = new CsvExporter();
            csv.Export();

            Console.WriteLine();

            DataExporter json = new JsonExporter();
            json.Export();
        }

        public void VisitorPattern()
        {
            var rootFolder = new Folder("Root");
            rootFolder.Add(new File("Resume.pdf", 120));
            rootFolder.Add(new File("Photo.jpg", 300));

            var subFolder = new Folder("Projects");
            subFolder.Add(new File("Project1.docx", 200));
            subFolder.Add(new File("Project2.pptx", 450));

            rootFolder.Add(subFolder);

            var visitor = new SizeCalculatorVisitor();
            rootFolder.Accept(visitor);

            Console.WriteLine($"Total Size: {visitor.TotalSize}KB");
        }
    }
}
