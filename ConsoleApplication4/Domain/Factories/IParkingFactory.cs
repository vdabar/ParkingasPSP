using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication4.Domain
{
    interface IParkingFactory
    {
        IParking CreateParking( string name, int parkingPlaces);
        CarSubject CreateCar(string name, string surname, string licensePlate);
    }
}
