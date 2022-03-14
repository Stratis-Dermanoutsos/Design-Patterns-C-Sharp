namespace DesignPatterns.Singleton;

/// <summary>
/// The Eager Initialization 'Singleton' class
/// </summary>
public sealed class EagerInitializationSingleton
{
    private static EagerInitializationSingleton instance = new EagerInitializationSingleton();

    public string Name { get; set; } = "EagerInitializationSingleton";

    private EagerInitializationSingleton() {}

    public static EagerInitializationSingleton Instance
    {
        get { return instance; }
    }
}