using Clinica.HelpApplication.Patterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.HelpApplication.Patterns.Subject
{
    public delegate void UpdateEventHandler(ISubject subject, object data);

    public interface ISubject
    {
        event UpdateEventHandler OnUpdate;
        void Notify(object data);

        //void Register(IObserver observer);

        //void Unregister(IObserver observer);
    }
}
