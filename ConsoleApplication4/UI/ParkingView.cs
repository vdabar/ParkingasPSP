using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.Domain;

namespace ConsoleApplication4.UI
{
    abstract class ParkingView : IParkingObserver,IParkingView
    {
        public abstract void UpdateParkingSlots(IParking Parking);

        public abstract void display();

        private int _id;

        protected ParkingView(int id)
        {
            _id = id;
        }
    }
}
