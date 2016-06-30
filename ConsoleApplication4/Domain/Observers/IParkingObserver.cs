using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication4.Domain
{
    interface IParkingObserver
    {
        void UpdateParkingSlots(IParking Parking);
    }
}
