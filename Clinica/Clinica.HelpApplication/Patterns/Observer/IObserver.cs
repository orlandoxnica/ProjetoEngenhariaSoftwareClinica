using Clinica.HelpApplication.Patterns.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.HelpApplication.Patterns.Observer
{
    public interface IObserver
    {
        void Update(ISubject subject, object data);
    }
}
