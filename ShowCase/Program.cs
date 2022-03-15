using DesignPatterns.Builder;
using DesignPatterns.Singleton;

LazyInitializationSingleton lazyinitializationsingleton = LazyInitializationSingleton.Instance;

Console.WriteLine(lazyinitializationsingleton.Name);

LazyInitializationSingleton lazyinitializationsingletonNew = LazyInitializationSingleton.Instance;
lazyinitializationsingletonNew.Name = "LazyInitializationSingleton changed";

Console.WriteLine(lazyinitializationsingleton.Name);

EagerInitializationSingleton eagerinitializationsingleton = EagerInitializationSingleton.Instance;

Console.WriteLine(eagerinitializationsingleton.Name);

EagerInitializationSingleton eagerinitializationsingletonNew = EagerInitializationSingleton.Instance;
eagerinitializationsingletonNew.Name = "EagerInitializationSingleton changed";

Console.WriteLine(eagerinitializationsingleton.Name);

Console.WriteLine("-------------");

Burger burger1 = new Burger()
                    .setHasCheese()
                    .setHasPickles();

Console.WriteLine(burger1);

Burger burger2 = new Burger()
                    .setHasOnions();

Console.WriteLine(burger2);

