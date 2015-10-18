using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace Logic
{
    public class AutoparkFactory
    {
        public static Autopark CreateAutopark()
        {
            Minibuses minibuses1 = new Minibuses();
            minibuses1.Name = "Mercedes-Benz V250";
            minibuses1.Price = 2452;
            minibuses1.Way = "Москва - Санкт-Петербург";
            minibuses1.Company = "ПАТП";
            minibuses1.Fuelconsumption = 12;
            minibuses1.Gradyear = 1998;

            Taxi taxi1 = new Taxi();
            taxi1.Name = "BMW M5";
            taxi1.Price = 300;
            taxi1.Way = "Вокзал - Киевская 23";
            taxi1.Company = "Лидер";
            taxi1.Color = "Синий";
            taxi1.Speed = 60;

            Autopark autopark = new Autopark();
            autopark.AddTransport(minibuses1);
            autopark.AddTransport(taxi1);

            return autopark;
        }
    }
}