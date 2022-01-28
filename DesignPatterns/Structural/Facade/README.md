# Facade

Facade is a structural design pattern that provides a simplified (but limited) interface to a complex system of classes, library or framework.


[Documentation](https://refactoring.guru/design-patterns)

## Structure

While Facade decreases the overall complexity of the application, it also helps to move unwanted dependencies to one place.


#### 1  - The Facade provides convenient access to a particular part of the subsystem’s functionality. It knows where to direct the client’s request and how to operate all the moving parts.


```csharp
    public class Facade
    {
        protected Subsystem1 _subsystem1;

        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }
    }
```

#### 2  - An Additional Facade class can be created to prevent polluting a single facade with unrelated features that might make it yet another complex structure. Additional facades can be used by both clients and other facades.



```csharp
    public class AdditionalFacade
    {
    }
```

#### 3  - The Complex Subsystem consists of dozens of various objects. To make them all do something meaningful, you have to dive deep into the subsystem’s implementation details, such as initializing objects in the correct order and supplying them with data in the proper format.



```csharp
    public class Subsystem1 { ... }
    
    public class Subsystem2 { ... }
```

#### 4  - The Client uses the facade instead of calling the subsystem objects directly.


```csharp
     Subsystem1 subsystem1 = new Subsystem1();
     Subsystem2 subsystem2 = new Subsystem2();
     Facade facade = new Facade(subsystem1, subsystem2);
     facade.Operation();
```


## Usage examples

The Facade pattern is commonly used in apps written in C#. It’s especially handy when working with complex libraries and APIs.

## Feedback

If you have any feedback, please reach out to us at felixmpa@gmail.com

## 

- [https://refactoring.guru/](https://refactoring.guru/)

