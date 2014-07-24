using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarPoolDomain
{
    public class Driver
    {

        public Driver(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string CellPhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string Address { get; set; }

        public int? Order
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public List<DateTime> DatesIDrove
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
