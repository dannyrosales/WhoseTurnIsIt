using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NodaTime;

namespace CarPoolDomain
{
    public class Scheduler
    {
        public Scheduler()
        {//ctor
            
        }

        private IClock myclock;
        


        public DateTime ACalendar { get; set; }

        //public IClock RightNow { get; set; }

        private void CheckHolidays()
        {
            
            
        }

        private void BuildCalendar(List<Period> listOfHolidays)
        {
            PeriodBuilder perdiodBuilder = new PeriodBuilder();
            //perdiodBuilder

        }
    }
}
