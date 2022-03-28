namespace DesignPatterns.Adapter;

using DesignPatterns.Adapter.Interfaces;

public class Target : ITarget
{
    public void Request()
    {
        Console.WriteLine("Called Request()");
    }
}