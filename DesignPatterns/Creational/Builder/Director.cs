using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class Director
    {

        private IBuilder _builder;

        //The code block for the get accessor is executed when the property is read; 
        //the code block for the set accessor is executed when the property is assigned a new value.
        //A property without a set accessor is considered read-only.A property without a get accessor 
        //is considered write-only.
        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }


    }
}
