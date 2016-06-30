using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication4.Domain
{
    interface IParking
    {
        int getParkingPlaces();
        int Id { get; set; }
        string Name { get; set; }
        void SetCarToParking(CarSubject car);
        void RemoveCarfromParking(CarSubject car);
        void Attach(IParkingObserver o);
    }
}
