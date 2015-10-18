using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class BigTransport : AbstractTransport
    {
        private int passengercount;
        private string dimensions;

        public int Passengercount
        {
            get { return passengercount; }
            set { passengercount = value; }
        }

        public string Dimensions
        {
            get { return dimensions; }
            set { dimensions = value; }
        }
    }
}