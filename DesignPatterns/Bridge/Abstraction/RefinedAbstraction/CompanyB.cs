using DesignPatterns.Bridge.Implementer;

namespace DesignPatterns.Bridge.Abstraction.RefinedAbstraction;

public class CompanyB : Application
{
    public CompanyB(IComponent component) : base(component)
    {
    }

    public override void Operation()
    {
        Component.OperationImplemented("CompanyB");
    }
}