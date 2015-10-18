using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Taxi : SmallTransport
    {
        private string color;
        private int speed;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}