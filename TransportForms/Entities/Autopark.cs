using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Autopark
    {
        private List<AbstractTransport> transport;

        public void AddTransport(AbstractTransport route)
        {
            if (transport == null)
            {
                transport = new List<AbstractTransport>();
            }

            transport.Add(route);
        }

        public List<AbstractTransport> Transport
        {
            get { return transport; }
        }
    }
}