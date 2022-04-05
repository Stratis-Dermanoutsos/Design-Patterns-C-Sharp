namespace DesignPatterns.Bridge.Implementer.ConcreteImplementer;

public class Header : IComponent
{
    public void OperationImplemented(string name)
    {
        Console.WriteLine("Header for " + name);
    }
}