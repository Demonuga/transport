using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Minibuses : SmallTransport
    {
        private int gradyear;

        public int Gradyear
        {
            get { return gradyear; }
            set { gradyear = value; }
        }
    }
}