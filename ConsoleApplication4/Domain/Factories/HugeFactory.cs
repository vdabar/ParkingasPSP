using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication4.Domain
{
    class HugeFactory : IParkingFactory
    {

        public IParking CreateParking(string name,  int parkingPlaces)
        {
            return new Camping(name, parkingPlaces);
        }

        public CarSubject CreateCar( string name, string surname, string licensePlate)
        {
            return new CarWithCamper(name, surname, licensePlate);
        }
    }
}
