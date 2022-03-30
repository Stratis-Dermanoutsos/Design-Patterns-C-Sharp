namespace DesignPatterns.Composite;

public class Composite : IComponent
{
    public string Name { get; set; }
    public List<IComponent> Children;

    public Composite(string Name)
    {
        this.Name = Name;
        this.Children = new List<IComponent>();
    }

    public void AddChild(IComponent component)
    {
        this.Children.Add(component);
    }

    public void RemoveChild(IComponent component)
    {
        this.Children.Remove(component);
    }

    public IComponent GetChildAt(int index)
    {
        return this.Children[index];
    }

    public void Operation()
    {
        Console.WriteLine("Opening " + this.Name);

        for (int i = 0; i < this.Children.Count; i++) {
            GetChildAt(i).Operation();
        }

        Console.WriteLine("Closing " + this.Name);
    }
}
