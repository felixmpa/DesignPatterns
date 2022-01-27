# Singleton

Singleton is a cretional design pattern that lets you ensure that a class has only on instance, while providing a global access point to this instance.


[Documentation](https://refactoring.guru/design-patterns)

## Structure

Singleton can be recognized by a static creation method, which returns the same cached object.

#### 1  - The Singleton’s constructor should be hidden from the client code. Calling the getInstance method should be the only way of getting the Singleton object.

```csharp
    public sealed class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if(_instance == null) 
            {
                //Note: if you're creating an app with multithereading support, you should place a thread lock here
                _instance = new Singleton()
            }
            return _instance;
        }
    }
```

## Usage examples

 A lot of developers consider the Singleton pattern an antipattern. That’s why its usage is on the decline in C# code.

## Feedback

If you have any feedback, please reach out to us at felixmpa@gmail.com

## 

- [https://refactoring.guru/](https://refactoring.guru/)

