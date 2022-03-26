namespace DesignPatterns.Factory.Model;

/// <summary>
/// A class 'dog' that inherits from the Animal interface.
/// </summary>
public class Dog : Animal
{
    public override string ToString()
    {
        return "This is a dog!";
    }
}