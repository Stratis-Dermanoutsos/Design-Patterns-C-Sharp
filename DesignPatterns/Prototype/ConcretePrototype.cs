namespace DesignPatterns.Prototype;

/// <summary>
/// The 'ConcretePrototype' class, which inherits from the 'Prototype' class.
/// </summary>
public class ConcretePrototype : Prototype
{
    public int Radius { get; set; }

    public ConcretePrototype(int X, int Y, int Radius)
        : base(X, Y)
    {
        this.Radius = Radius;
    }

    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"X: {this.X}, Y: {this.Y}, Radius: {this.Radius}";
    }
}