# Observer

Observer is a behavioral design pattern that allows some objects to notify other objects about changes in their state.



[Documentation](https://refactoring.guru/design-patterns)

## Structure

The Observer pattern provides a way to subscribe and unsubscribe to and from these events for any object that implements a subscriber interface.



#### The Subscriber interface declares the notification interface. In most cases, it consists of a single update method. The method may have several parameters that let the publisher pass some event details along with the update.

```csharp
   public interface ISubject
    {
        // Attach an observer to the subject.
        void Attach(IObserver observer);

        // Detach an observer from the subject.
        void Detach(IObserver observer);

        // Notify all observers about an event.
        void Notify();
    }
```

#### Concrete Subscribers perform some actions in response to notifications issued by the publisher. All of these classes must implement the same interface so the publisher isn’t coupled to concrete classes.

```csharp
  class ConcreteObserverB : IObserver
  {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
  }
```


## Usage examples

The Observer pattern is pretty common in C# code, especially in the GUI components. It provides a way to react to events happening in other objects without coupling to their classes.
## Feedback

If you have any feedback, please reach out to us at felixmpa@gmail.com

## 

- [https://refactoring.guru/](https://refactoring.guru/)

