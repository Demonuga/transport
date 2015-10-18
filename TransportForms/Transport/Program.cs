using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Logic;

namespace TransportConsole
{
    class Program
    {
        public static void Main()
        {
            Autopark autopark = AutoparkFactory.CreateAutopark();
            int totalPrice = AutoparkCalculator.CalculatePrice(autopark);
            AutoparkPrinter.Print(autopark, totalPrice);
        }
    }
}