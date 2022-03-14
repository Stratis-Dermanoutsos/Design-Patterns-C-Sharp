using DesignPatterns.Singleton;

Singleton singleton = Singleton.Instance;

Console.WriteLine(singleton.Name);

Singleton singletonNew = Singleton.Instance;
singletonNew.Name = "Singleton changed";

Console.WriteLine(singleton.Name);
