using DesignPatterns.Builder;
using DesignPatterns.Factory;
using DesignPatterns.Factory.Model;
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

Console.WriteLine("-------------");

Animal dog = AnimalFactory.CreateAnimal("Dog");
Console.WriteLine(dog);

Animal cat = AnimalFactory.CreateAnimal("Cat");
Console.WriteLine(cat);
