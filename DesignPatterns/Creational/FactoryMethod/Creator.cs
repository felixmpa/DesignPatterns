using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    //The creator class declares the factory method that is supposed to return an object of Product class.
    abstract class Creator
    {
        //default implementatio of the factory method
        public abstract IProduct FactoryMethod();

        //the Creator's primary responsibility is not creating products. 
        // Usually, it contains some core business logic that relies on Product objects, returned by the factory method. 
        public string SomeOperation()
        {
            var product = FactoryMethod();

            var result = "Creator: The same creator's code has just worked with " + product.Operation();

            return result;
        }

    }
}
