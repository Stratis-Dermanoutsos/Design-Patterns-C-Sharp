using DesignPatterns.Bridge.Implementer;

namespace DesignPatterns.Bridge.Abstraction;

public abstract class Application
{
    public IComponent Component { get; set; }

    protected Application(IComponent component)
    {
        Component = component;
    }

    public abstract void Operation();
}