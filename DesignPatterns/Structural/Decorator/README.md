# Decorator

Decorator is a structural pattern that allows adding new behaviors to objects dynamically by placing them inside special wrapper objects.


[Documentation](https://refactoring.guru/design-patterns)

## Structure

Using decorators you can wrap objects countless number of times since both target objects and decorators follow the same interface. The resulting object will get a stacking behavior of all wrappers.

#### 1  - The Component declares the common interface for both wrappers and wrapped objects.

```csharp
    public abstract class Component
    {
        public abstract string Operation();
    }
```

#### 2  - Concrete Component is a class of objects being wrapped. It defines the basic behavior, which can be altered by decorators.

```csharp
    class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
```

#### 3  - The Base Decorator class has a field for referencing a wrapped object. The field’s type should be declared as the component interface so it can contain both concrete components and decorators. The base decorator delegates all operations to the wrapped object.


```csharp
     abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            this._component = component;
        }

        public void SetComponent(Component component)
        {
            this._component = component;
        }
         public override string Operation() { ... }
    }
```


#### 4  - Concrete Decorators define extra behaviors that can be added to components dynamically. Concrete decorators override methods of the base decorator and execute their behavior either before or after calling the parent method.


```csharp
   class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    } 
```


#### 5  - The Client can wrap components in multiple layers of decorators, as long as it works with all objects via the component interface.

```csharp
     public void ClientCode(Component component)
     {
            Console.WriteLine("RESULT: " + component.Operation());
     }
```



## Usage examples

 A lot of developers consider the Singleton pattern an antipattern. That’s why its usage is on the decline in C# code.

## Feedback

If you have any feedback, please reach out to us at felixmpa@gmail.com

## 

- [https://refactoring.guru/](https://refactoring.guru/)

