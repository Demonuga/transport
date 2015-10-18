using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace Logic
{
    public class AutoparkCalculator
    {
        public static int CalculatePrice(Autopark autopark)
        {
            int totalPrice = 0;

            List<AbstractTransport> transport = autopark.Transport;

            foreach (AbstractTransport route in transport)
            {
                if (route.Price != null)
                    totalPrice = totalPrice + route.Price;
            }

            return totalPrice;
        }
    }
}