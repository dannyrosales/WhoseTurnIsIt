using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NodaTime;

namespace CarPoolDomain
{
    public class CarPoolManager 
    {
        private IDriverOrderEventListener _driverOrderEventListener;
        private IDrivingCalendarEventListener _drivingCalendarEventListener;

        public CarPoolManager(IDriverOrderEventListener driverOrderEventListener, IDrivingCalendarEventListener drivingCalendarEventListener) 
        {//ctor
            _driverOrderEventListener = driverOrderEventListener;
            _drivingCalendarEventListener = drivingCalendarEventListener;
        }

        public List<Driver> ListOfDrivers;

        public List<Driver> ResetOrderOnDriverList()
        {
            return _driverOrderEventListener.SetOrderOnDriverList();
        }

        public void SetDrivingDaysOnCarPoolManager(List<LocalDate> NoDriveHolidays)
        {
            _drivingCalendarEventListener.SetDrivingDays(NoDriveHolidays);
        }

       


        
    }
}
