using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarPoolDomain
{
    public interface IDriverOrderEventListener
    {
        List<Driver> SetOrderOnDriverList();
    }
}
