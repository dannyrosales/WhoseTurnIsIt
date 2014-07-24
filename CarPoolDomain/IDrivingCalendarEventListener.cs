using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NodaTime;

namespace CarPoolDomain
{
    public interface IDrivingCalendarEventListener
    {
        //set the driving days for the year, while removing holidays, later
        //discover and remove weekend days, if their day of the week number is 0 or 6        
        void SetDrivingDays(List<LocalDate> holidaysToRemove);
    }
}
