namespace DesignPatterns.Bridge.Implementer.ConcreteImplementer;

public class Sidemenu : IComponent
{
    public void OperationImplemented(string name)
    {
        Console.WriteLine("Sidemenu for " + name);
    }
}