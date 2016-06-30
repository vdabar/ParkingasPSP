using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication4.Domain
{
    abstract class CarSubject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LicensePlate { get; set; }
        public bool IsParked { get; set; }
        private List<ICarObserver> observerList = new List<ICarObserver>();

        public void Attach(ICarObserver o)
        {
            observerList.Add(o);
        }

        public void Detach(ICarObserver o)
        {
            observerList.Remove(o);
        }

        public void NotifyObserversAboutParkingPlaces()
        {
            foreach (ICarObserver o in observerList)
            {
                o.UpdateCar(this);
            }
        }


    }
}
