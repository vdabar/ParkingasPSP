using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.Domain;
using ConsoleApplication4.Domain.Repositories;

namespace ConsoleApplication4.UI
{
    class ParkingListItemView :ParkingView
    {
        private string name;
        private int places;
        private int _id;

        private ParkingRepository _parkingRepository;
        private int parkingSpaces;
        

        public ParkingListItemView(int id, ParkingRepository parkingRepository):base(id)
        {
            _parkingRepository = parkingRepository;
            _id = id;
            Initialize();
        }

        public override void display()
        {
            
            Console.Write("Id: " + _id +
                          " | Pavadinimas: " + name                      
                          );
        }

        public override void UpdateParkingSlots(IParking parking)
        {
            name = parking.Name;
            parkingSpaces = parking.getParkingPlaces();
            Console.WriteLine("\n Likusiu vietu skaicius: " + parkingSpaces);
        }

        private void Initialize()
        {
            var parking = _parkingRepository.Find(_id);
            UpdateParkingSlots(parking);
        }
    }
}
