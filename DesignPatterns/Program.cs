using System;


namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //FactoryMethod
            //new DesignPatterns.Creational.FactoryMethod.Client().Main();

            //Prototype
            //new DesignPatterns.Creational.Prototype.Client().Main();

            //Singleton
            //new DesignPatterns.Creational.Singleton.Client().Main();

            //Abstract Factory
            //new DesignPatterns.Creational.AbstractFactory.Client().Main();

            //Builder
            //new DesignPatterns.Creational.Builder.Client().Main();

            //Decorator
            //new DesignPatterns.Structural.Decorator.Client().Main();

            //Facade
            new DesignPatterns.Structural.Facade.Client().Main();

        }
    }
}
