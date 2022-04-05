

using DesignPatterns.Bridge.Implementer;

namespace DesignPatterns.Bridge.Abstraction.RefinedAbstraction;

public class CompanyA : Application
{
    public CompanyA(IComponent component) : base(component)
    {
    }

    public override void Operation()
    {
        Component.OperationImplemented("CompanyA");
    }
}