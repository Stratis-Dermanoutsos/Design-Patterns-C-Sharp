namespace DesignPatterns.Singleton;

/// <summary>
/// The Lazy Initialization 'Singleton' class
/// </summary>
public sealed class LazyInitializationSingleton
{
    private static LazyInitializationSingleton? instance = null;

    public string Name { get; set; } = "LazyInitializationSingleton";

    private LazyInitializationSingleton() {}

    public static LazyInitializationSingleton Instance
    {
        get {
            if (instance == null)
                instance = new LazyInitializationSingleton();

            return instance;
        }
    }
}