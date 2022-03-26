namespace DesignPatterns.Factory.Model;

/// <summary>
/// A class 'cat' that inherits from the Animal interface.
/// </summary>
public class Cat : Animal
{
    public override string ToString()
    {
        return "This is a cat!";
    }
}