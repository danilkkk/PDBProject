using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBProject1
{
    public class SecondSubscriber : ISubscriber
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("Second Subscriber received a message: {0}", (subject as Countdown).message);
        }
    }
}
