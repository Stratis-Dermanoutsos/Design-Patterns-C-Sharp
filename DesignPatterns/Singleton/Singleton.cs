namespace DesignPatterns.Singleton;

public sealed class Singleton
{
    private static Singleton? instance = null;

    public string Name { get; set; } = "Singleton";

    private Singleton() {}

    public static Singleton Instance
    {
        get {
            if (instance == null)
                instance = new Singleton();

            return instance;
        }
    }
}