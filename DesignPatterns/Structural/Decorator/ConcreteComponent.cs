using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    class ConcreteComponent : Component
    {
        // Concrete Components provide default implementations of the operations.
        // There might be several variations of these classes.
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}
