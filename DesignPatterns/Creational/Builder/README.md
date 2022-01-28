# Builder

Builder is a creational design pattern, which allows constructing complex objects step by step.


[Documentation](https://refactoring.guru/design-patterns)

## Builder

Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

#### 1  - The Builder interface declares product construction steps that are common to all types of builders.

```csharp
    public interface IBuilder
    {
        void BuildPartA();
        
        void BuildPartB();
        
        void BuildPartC();
    }
```

#### 2  - Concrete Builders provide different implementations of the construction steps. Concrete builders may produce products that don’t follow the common interface.

```csharp
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this._product = new Product();
        }

        public void BuildPartA() { ... }
         
        public void BuildPartB() { ... }
         
        public void BuildPartC() { ... }

        public Product GetProduct()
        {
            //Reset product it's a usual practice
            return this._product;
        }
    }
```

#### 3  - Products are resulting objects. Products constructed by different builders don’t have to belong to the same class hierarchy or interface.

```csharp
    public class Product
    {
        
    }
```

#### 4  - The Director class defines the order in which to call construction steps, so you can create and reuse specific configurations of products.

```csharp
    public class Director
    {
        private IBuilder _builder;

        public void BuildProductWithOnePart() { ... }
        
        public void BuildProductWithAllParts() { ... }
    }
```


#### 4  - The Client must associate one of the builder objects with the director. Usually, it’s done just once, via parameters of the director’s constructor. Then the director uses that builder object for all further construction.

```csharp
    class Client
    {
        public void Main()
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;
            director.BuildMinimalViableProduct();
        }
    }
```


## Usage examples

The Builder pattern is a well-known pattern in C# world. It’s especially useful when you need to create an object with lots of possible configuration options.

## Feedback

If you have any feedback, please reach out to us at felixmpa@gmail.com

## 

- [https://refactoring.guru/](https://refactoring.guru/)

