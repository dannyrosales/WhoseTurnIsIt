using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarPoolDomain;
using NSubstitute;
using NodaTime;


namespace CarPoolDomain.Tests
{
    [TestClass]
    public class CarPoolManagerTests
    {

        //Object Under Test
        private CarPoolManager _carPoolManager;
        //data the out manages
        private List<Driver> _listOfDrivers;
        //collaborators
        private IDriverOrderEventListener _driverOrderEventListener;
        private IDrivingCalendarEventListener _drivingCalendarEventListener;

        [TestInitialize]
        public void Setup_CarPoolManager()
        {
            //interface identifies the role the object under test(OUT) collaborates with
            _driverOrderEventListener = Substitute.For<IDriverOrderEventListener>();
            _drivingCalendarEventListener = Substitute.For<IDrivingCalendarEventListener>();

            //object under test(OUT)
            _carPoolManager = new CarPoolManager(_driverOrderEventListener, _drivingCalendarEventListener);

            //list of data the OUT manages
            _listOfDrivers = new List<Driver>() { new Driver("sue", "ros"), new Driver("dan", "sue") };
            _carPoolManager.ListOfDrivers = _listOfDrivers;
        }


        [TestMethod]
        public void SetOrderOnDriverList_IsCalledCorrectly()
        {
            _carPoolManager.ResetOrderOnDriverList();
            _driverOrderEventListener.Received().SetOrderOnDriverList();
        }
               
        [TestMethod]
        public void SetDrivingDaysOnCarPoolManager_IsCalledCorrectly()
        {            
            //ARRANGE
            List<LocalDate> aListOfHolidays = new List<LocalDate>();
            //ACT
            _carPoolManager.SetDrivingDaysOnCarPoolManager(aListOfHolidays);
            //ASSERT
            _drivingCalendarEventListener.Received().SetDrivingDays(aListOfHolidays);
        }

        [TestMethod]
        public void DesignateDriverNewDay_EventIsRaisedCorrectly()
        {
            //arrange
            var wasCalled = false;
            _drivingCalendarEventListener.DesignateDriverOnNewDay += (sender, args) => wasCalled = true;

            //act
            _drivingCalendarEventListener.DesignateDriverOnNewDay += Raise.Event();

            //assert/
            Assert.IsTrue(wasCalled);
        }

    }
}
