namespace DesignPatterns.Builder;

/// <summary>
/// The 'Builder' class.
/// </summary>
public class Burger
{
    public bool hasCheese { get; set; } = false;
    public bool hasPickles { get; set; } = false;
    public bool hasOnions { get; set; } = false;
    public bool hasMayo { get; set; } = false;

    public Burger() { }

    public Burger setHasCheese ()
    {
        this.hasCheese = true;
        return this;
    }

    public Burger setHasPickles ()
    {
        this.hasPickles = true;
        return this;
    }

    public Burger setHasOnions ()
    {
        this.hasOnions = true;
        return this;
    }

    public Burger setHasMayo ()
    {
        this.hasMayo = true;
        return this;
    }

    public override string ToString ()
    {
        return $"{(this.hasCheese ? "cheese " : "")}{(this.hasPickles ? "pickles " : "")}{(this.hasOnions ? "onions " : "")}{(this.hasMayo ? "mayo " : "")}";
    }
}