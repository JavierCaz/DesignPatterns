using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge.Abstraction;
using DesignPatterns.Structural.Bridge.Implementor;
using DesignPatterns.Structural.Decorator.Component;
using DesignPatterns.Structural.Decorator.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural
{
    internal class StructuralClient
    {
        public void AdapterPattern()
        {
            IShape shape = new TextShape(new TextView());
            shape.Draw();
        }

        public void BridgePattern()
        {
            Message msg1 = new RegularMessage(new EmailSender());
            msg1.Send("Meeting Reminder", "Don't forget the meeting at 10 AM.");

            Message msg2 = new UrgentMessage(new SMSSender());
            msg2.Send("Server Down", "Please check the server immediately!");
        }

        public void CompositePattern()
        {
            var root = new DesignPatterns.Structural.Composite.Folder("Root");
            root.Add(new DesignPatterns.Structural.Composite.File("file1.txt"));
            root.Add(new DesignPatterns.Structural.Composite.File("file2.txt"));

            var subFolder = new DesignPatterns.Structural.Composite.Folder("SubFolder");
            subFolder.Add(new DesignPatterns.Structural.Composite.File("file3.txt"));
            subFolder.Add(new DesignPatterns.Structural.Composite.File("file4.txt"));

            root.Add(subFolder);
            root.Display();
        }

        public void DecoratorPattern()
        {
            INotifier notifier = new BasicNotifier();
            notifier = new EncryptedNotifier(notifier);
            notifier = new PriorityNotifier(notifier);

            notifier.Send("System update required.");
        }

        public void FacadePattern()
        {
            var homeFacade = new HomeAutomationFacade();

            homeFacade.LeaveHome();
            Console.WriteLine();
            homeFacade.ArriveHome();
        }

        public void FlyweightPattern()
        {
            var charFactory = new CharacterFactory();
            string text = "HI😊";
            string font = "Arial";
            int size = 12;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (char.IsLetter(c))
                {
                    ICharacter sharedChar = charFactory.GetCharacter(c, font, size);
                    sharedChar.Display($"position {i}");
                }
                else
                {
                    ICharacter specialChar = new SpecialCharacter(c.ToString(), "emoji");
                    specialChar.Display($"position {i}");
                }
            }
        }

        public void ProxyPattern()
        {
            IImage image1 = new ImageProxy("photo1.jpg");
            IImage image2 = new ImageProxy("photo2.jpg");

            Console.WriteLine("Images created, but not loaded yet.");

            image1.Display();
            image2.Display();
        }
    }
}
