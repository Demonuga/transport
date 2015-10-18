using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace TransportConsole
{
    class AutoparkPrinter
    {
        public static void Print(Autopark autopark, int totalPrice)
        {

            List<AbstractTransport> transport = autopark.Transport;

            foreach (AbstractTransport route in transport)
            {
                Console.WriteLine("Название: " + route.Name);
                Console.WriteLine("Цена проезда: " + route.Price);
                Console.WriteLine("Путь: " + route.Way);
                Console.WriteLine();
            }

            Console.WriteLine("Общая стоимость поездки: " + totalPrice);
            Console.ReadKey();
        }
    }
}