# Factory Method

Factory method is a creational design pattern which solves the problem of creating product objects without
specifying their concrete classes.

[Documentation](https://refactoring.guru/design-patterns/factory-method/csharp/example)

## Structure

The code that uses the factory method (often called the client code) doesn’t see a difference between the actual products returned by various subclasses. 

#### 1  - The Product declares the interface, which is common to all objects that can be produced by the creator and its subclasses.

```csharp
    public interface IProduct
    {
      string Operation();
    }
```

#### 2  - Concrete Products are different implementations of the product interface.

```csharp
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
```

#### 3  - The Creator class declares the factory method that returns new product objects. It’s important that the return type of this method matches the product interface.

```csharp
    abstract class Creator
    {
        //default implementatio of the factory method
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
        }
    }  
```

#### 4  - Concrete Creators override the base factory method so it returns a different type of product.

```csharp
    class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    } 
```
## Feedback

If you have any feedback, please reach out to us at felixmpa@gmail.com

## 

- [https://refactoring.guru/](https://refactoring.guru/)

