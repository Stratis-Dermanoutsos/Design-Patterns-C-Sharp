﻿using DesignPatterns.Adapter;
using DesignPatterns.Bridge.Abstraction;
using DesignPatterns.Bridge.Abstraction.RefinedAbstraction;
using DesignPatterns.Bridge.Implementer.ConcreteImplementer;
using DesignPatterns.Builder;
using DesignPatterns.Composite;
using DesignPatterns.Facade;
using DesignPatterns.Factory;
using DesignPatterns.Factory.Model;
using DesignPatterns.Prototype;
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

Console.WriteLine("-------------");

ConcretePrototype cp1 = new ConcretePrototype(1, 2, 3);
ConcretePrototype cp2 = (ConcretePrototype)cp1.Clone();

Console.WriteLine("Before cp1 change.");
Console.WriteLine(cp1);
Console.WriteLine(cp2);

cp1.X = 10;

Console.WriteLine("After cp1 change.");
Console.WriteLine(cp1);
Console.WriteLine(cp2);

Console.WriteLine("-------------");

Adaptee adaptee = new Adaptee();
Target target = new Target();

Adapter adapter = new Adapter(adaptee);

Console.Write("Adaptee...");
adaptee.SpecificRequest();

Console.Write("Target...");
target.Request();

Console.Write("Adapter...");
adapter.Request();

Console.WriteLine("-------------");

BackupServer backupServer = new BackupServer();
BackupServerFacade backupServerFacade = new BackupServerFacade(backupServer);

Console.WriteLine("SERVER START WITHOUT FACADE.");

backupServer.Boot();
backupServer.DiskHealthCheck();
backupServer.StartProcesses();
backupServer.InitializeListeners();

Console.WriteLine("SERVER START WITH FACADE.");

backupServerFacade.StartServer();

Console.WriteLine("SERVER STOP WITHOUT FACADE.");

backupServer.DestroyListeners();
backupServer.ReleaseProcesses();
backupServer.EjectDrives();
backupServer.Shutdown();

Console.WriteLine("SERVER STOP WITH FACADE.");

backupServerFacade.StopServer();

Console.WriteLine("-------------");

Composite composite1 = new Composite("Parent 1");

Leaf leaf1 = new Leaf("Leaf 1");
Leaf leaf2 = new Leaf("Leaf 2");
Composite composite2 = new Composite("Parent 2");
Leaf leaf3 = new Leaf("Leaf 3");

composite1.AddChild(leaf1);
composite1.AddChild(leaf2);
composite1.AddChild(composite2);
composite2.AddChild(leaf3);

composite1.Operation();

Console.WriteLine("-------------");

Header header = new Header();
Sidemenu sidemenu = new Sidemenu();

Application company = new CompanyA(header);
company.Operation();

company = new CompanyA(sidemenu);
company.Operation();

company = new CompanyB(header);
company.Operation();