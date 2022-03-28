namespace DesignPatterns.Adapter;

using DesignPatterns.Adapter.Interfaces;

public class Adapter : ITarget
{
    IAdaptee adaptee;

    public Adapter(IAdaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public void Request()
    {
        adaptee.SpecificRequest();
    }
}