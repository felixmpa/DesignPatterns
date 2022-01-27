using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Singleton
{
    //The Singleton should always be a 'sealed' class to prevent class
    //inheritance through external classes and also through nested classes.
    public sealed class Singleton
    {
        //The constructor should always be private to prevent direct construction calls with the \new\ operator
        private Singleton() { }

        //The Singleton's instance is stored in a static field
        private static Singleton _instance;

        //This is the static method to controls the acces to the singleton instance.
        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public static void someBusinessLogic()
        {
            Console.WriteLine(" Executing some business logic.");
        }

    }
}
