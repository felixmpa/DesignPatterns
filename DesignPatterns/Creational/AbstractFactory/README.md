# Abstract Factory

Abstract Factory is creational design pattern that lets you produce families of related objects without specifying their concrete classes.


[Documentation](https://refactoring.guru/design-patterns)

## Structure

The pattern is easy to recognize by methods, which return a factory object. Then, the factory is used for creating specific sub-components.


#### 1  - Abstract Products declare interfaces for a set of distinct but related products which make up a product family.

```csharp
    public interface IAbstractProductA
    {
    }

    public interface IAbstractProductB
    {
    }
```

#### 2  - Concrete Products are various implementations of abstract products, grouped by variants. Each abstract product (chair/sofa) must be implemented in all given variants (Victorian/Modern).

```csharp
    // Concrete Products are created by corresponding Concrete Factories.
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }

    class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
```

#### 3  - The Abstract Factory interface declares a set of methods for creating each of the abstract products.

```csharp
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
```


#### 4  - Concrete Factories implement creation methods of the abstract factory. Each concrete factory corresponds to a specific variant of products and creates only those product variants.

```csharp
     // Each Concrete Factory has a corresponding product variant.
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
```

## Usage examples

The Abstract Factory pattern is pretty common in C# code. Many frameworks and libraries use it to provide a way to extend and customize their standard components.

## Feedback

If you have any feedback, please reach out to us at felixmpa@gmail.com

## 

- [https://refactoring.guru/](https://refactoring.guru/)

