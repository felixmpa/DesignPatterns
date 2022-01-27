# Prototype

Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.

[Documentation](https://refactoring.guru/design-patterns)

## Structure

The prototype can be easily recognized by a clone or copy methods, etc

#### 1  - The Prototype interface declares the cloning methods. In most cases, it’s a single clone method.

```csharp
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }
        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name   = String.Copy(Name);
            return clone;
        }
    }
```

#### 2  - The Concrete Prototype class implements the cloning method. In addition to copying the original object’s data to the clone, this method may also handle some edge cases of the cloning process related to cloning linked objects, untangling recursive dependencies, etc.

```csharp
    class ConcretePerson : Person
    {
        public ConcretePerson ShallowCopy()
        {
            return (ConcretePerson)this.MemberwiseClone();
        }
    }
```

#### 3  - The Client can produce a copy of any object that follows the prototype interface

```csharp
    class Client
    {
        public void Main()
        {
            Person p1 = new Person();

            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1991-01-01");
            p1.Name = "Jack Millennial";
            p1.IdInfo = new IdInfo(001);

            // Perform a shallow copy of p1 and assign it to p2.
            Person p2 = p1.ShallowCopy();
            // Make a deep copy of p1 and assign it to p3.
            Person p3 = p1.DeepCopy();
        }
    }
```

## Feedback

If you have any feedback, please reach out to us at felixmpa@gmail.com

## 

- [https://refactoring.guru/](https://refactoring.guru/)

