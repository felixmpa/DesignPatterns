using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
