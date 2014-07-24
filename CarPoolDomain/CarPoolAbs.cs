using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NodaTime;

namespace CarPoolDomain
{
   public abstract class CarPoolAbs
    {
       public CarPoolAbs(IDriverOrderEventListener aDriverOrderEventListener, IDrivingCalendarEventListener aDrivingCalendarEventListener)
       {//ctor
       }
       public string Name { get; set; }

       public List<Driver> ListOfDrivers;

       public int NumberOfDrivers { get; set; }
    }
}
