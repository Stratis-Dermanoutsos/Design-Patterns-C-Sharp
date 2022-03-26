namespace DesignPatterns.Factory;

using DesignPatterns.Factory.Model;

public class AnimalFactory
{
    public static Animal CreateAnimal(string animalType)
    {
        switch (animalType)
        {
            case "Dog":
                return new Dog();
            case "Cat":
                return new Cat();
            default:
                throw new ArgumentException("Invalid animal type.");
        }
    }
}