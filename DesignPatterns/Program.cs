using DesignPatterns.Behavioral;
using DesignPatterns.Creational;
using DesignPatterns.Structural;

CreationalClient creationalClient = new CreationalClient();
StructuralClient structuralClient = new StructuralClient();
BehavioralClient behavioralClient = new BehavioralClient();

var categoryHandlers = new Dictionary<PatternCategory, Action>
{
    { PatternCategory.Creational, () => ShowPatternMenu("Creational Patterns", Enum.GetValues(typeof(CreationalPattern)), GetCreationalActions()) },
    { PatternCategory.Structural, () => ShowPatternMenu("Structural Patterns", Enum.GetValues(typeof(StructuralPattern)), GetStructuralActions()) },
    { PatternCategory.Behavioral, () => ShowPatternMenu("Behavioral Patterns", Enum.GetValues(typeof(BehavioralPattern)), GetBehavioralActions()) }
};

bool running = true;
while (running)
{
    Console.WriteLine("Select a Design Pattern Category:");
    foreach (PatternCategory category in Enum.GetValues(typeof(PatternCategory)))
    {
        Console.WriteLine($"{(int)category}. {category}");
    }

    if (int.TryParse(Console.ReadLine(), out int categoryChoice) &&
        Enum.IsDefined(typeof(PatternCategory), categoryChoice))
    {
        categoryHandlers[(PatternCategory)categoryChoice].Invoke();
    }
    else
    {
        Console.WriteLine("Invalid category selection.");
    }

    Console.WriteLine("Do you want to test another pattern? (y/n)");
    string again = Console.ReadLine();
    running = again?.Trim().ToLower() == "y";
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();

void ShowPatternMenu(string title, Array enumValues, Dictionary<int, Action> actions)
{
    Console.WriteLine($"\nSelect a {title}:");

    foreach (var value in enumValues)
    {
        Console.WriteLine($"{(int)value}. {value}");
    }

    if (int.TryParse(Console.ReadLine(), out int patternChoice) && actions.TryGetValue(patternChoice, out var action))
    {
        Console.WriteLine($"\n--- Running {(Enum)Enum.ToObject(enumValues.GetType().GetElementType(), patternChoice)} ---\n");
        action.Invoke();
    }
    else
    {
        Console.WriteLine("Invalid pattern selection.");
    }
}

Dictionary<int, Action> GetCreationalActions() => new()
{
    { (int)CreationalPattern.FactoryMethod, creationalClient.FactoryMethod },
    { (int)CreationalPattern.AbstractFactory, creationalClient.AbstractFactory },
    { (int)CreationalPattern.Builder, creationalClient.Builder },
    { (int)CreationalPattern.Prototype, creationalClient.Prototype },
    { (int)CreationalPattern.Singleton, creationalClient.Singleton }
};

Dictionary<int, Action> GetStructuralActions() => new()
{
    { (int)StructuralPattern.Adapter, structuralClient.AdapterPattern },
    { (int)StructuralPattern.Bridge, structuralClient.BridgePattern },
    { (int)StructuralPattern.Composite, structuralClient.CompositePattern },
    { (int)StructuralPattern.Decorator, structuralClient.DecoratorPattern },
    { (int)StructuralPattern.Facade, structuralClient.FacadePattern },
    { (int)StructuralPattern.Flyweight, structuralClient.FlyweightPattern },
    { (int)StructuralPattern.Proxy, structuralClient.ProxyPattern }
};

Dictionary<int, Action> GetBehavioralActions() => new()
{
    { (int)BehavioralPattern.ChainOfResponsibility, behavioralClient.ChainOfResponsibilityPattern },
    { (int)BehavioralPattern.Command, behavioralClient.CommandPattern },
    { (int)BehavioralPattern.Interpreter, behavioralClient.InterpreterPattern },
    { (int)BehavioralPattern.Iterator, behavioralClient.IteratorPattern },
    { (int)BehavioralPattern.Mediator, behavioralClient.MediatorPattern },
    { (int)BehavioralPattern.Memento, behavioralClient.MementoPattern },
    { (int)BehavioralPattern.Observer, behavioralClient.ObserverPattern },
    { (int)BehavioralPattern.State, behavioralClient.StatePattern },
    { (int)BehavioralPattern.Strategy, behavioralClient.StrategyPattern },
    { (int)BehavioralPattern.TemplateMethod, behavioralClient.TemplateMethodPattern },
    { (int)BehavioralPattern.Visitor, behavioralClient.VisitorPattern }
};
