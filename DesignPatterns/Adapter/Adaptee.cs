namespace DesignPatterns.Adapter;

using DesignPatterns.Adapter.Interfaces;

public class Adaptee : IAdaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Called SpecificRequest()");
    }
}