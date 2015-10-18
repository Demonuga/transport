using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public abstract class AbstractTransport
    {
        private string name;
        private int price;
        private string way;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Way
        {
            get { return way; }
            set { way = value; }
        }
    }
}