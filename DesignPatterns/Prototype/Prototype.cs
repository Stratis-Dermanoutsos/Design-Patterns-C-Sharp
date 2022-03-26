namespace DesignPatterns.Prototype;

/// <summary>
/// The 'Prototype' abstract class.
/// </summary>
public abstract class Prototype
{
    public int X { get; set; }
    public int Y { get; set; }

    public Prototype(int X, int Y)
    {
        this.X = X;
        this.Y = Y;
    }

    public abstract Prototype Clone();
}