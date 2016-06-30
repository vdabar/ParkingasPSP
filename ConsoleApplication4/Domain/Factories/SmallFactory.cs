using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication4.Domain
{
    class SmallFactory : IParkingFactory
    {
        public CarSubject CreateCar(string name, string surname, string licensePlate)
        {
            return new SimpleCar( name, surname, licensePlate);
        }

        public IParking CreateParking(string name, int parkingPlaces)
        {
            return new RegularCarParking(name,  parkingPlaces);
        }

    
      
    }
}
