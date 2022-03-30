namespace DesignPatterns.Composite;

public class Leaf : IComponent
{
    public string Name { get; set; }

    public Leaf(string Name)
    {
        this.Name = Name;
    }

    public void AddChild(IComponent component) => throw new NotImplementedException();

    public void RemoveChild(IComponent component) => throw new NotImplementedException();

    public IComponent GetChildAt(int index) => throw new NotImplementedException();

    public void Operation()
    {
        Console.WriteLine(this.Name);
    }
}
