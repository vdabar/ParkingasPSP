using ConsoleApplication4.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication4.Domain
{
    abstract class ParkingSubject:IParking
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
 


        List<CarSubject> cars = new List<CarSubject>();
        private int _parkingPlaces;
    
        private List<IParkingObserver> observerList = new List<IParkingObserver>();

        // Constructor
        public ParkingSubject(int parkingSpaces)
        {
            _parkingPlaces = parkingSpaces;
            
        }

        public void Attach(IParkingObserver o)
        {
            observerList.Add(o);
        }

        public void Detach(IParkingObserver o)
        {
            observerList.Remove(o);
        }

        public void NotifyObserversAboutParkingPlaces()
        {
            foreach (IParkingObserver o in observerList)
            {
                o.UpdateParkingSlots(this);
            }
        }

        public void SetCarToParking(CarSubject car)
        {
            if (_parkingPlaces > 1)
            {
                this.cars.Add(car);
                _parkingPlaces--;
                NotifyObserversAboutParkingPlaces();
              
            }
        }

        public void RemoveCarfromParking(CarSubject car)
        {
            this.cars.Remove(car);
            NotifyObserversAboutParkingPlaces();
            _parkingPlaces++;
        }

        public int getParkingPlaces()
        {
            return _parkingPlaces;
        }
    }
}
