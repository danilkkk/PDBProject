using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBProject1
{
    public interface ISubject
    {
        void Subscribe(ISubscriber observer);

        void Unsubscribe(ISubscriber observer);

        void Notify();
    }
}
