using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class SmallTransport : AbstractTransport
    {
        private string company;
        private int fuelconsumption;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public int Fuelconsumption
        {
            get { return fuelconsumption; }
            set { fuelconsumption = value; }
        }
    }
}