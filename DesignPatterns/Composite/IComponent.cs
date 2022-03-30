namespace DesignPatterns.Composite;

public interface IComponent
{
    void AddChild(IComponent component);
    void RemoveChild(IComponent component);
    IComponent GetChildAt(int index);
    void Operation();
}
