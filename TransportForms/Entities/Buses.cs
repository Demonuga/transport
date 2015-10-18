using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Buses : BigTransport
    {
        private string parkname;

        public string Parkname
        {
            get { return parkname; }
            set { parkname = value; }
        }
    }
}