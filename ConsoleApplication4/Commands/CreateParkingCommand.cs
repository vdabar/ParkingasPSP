using ConsoleApplication4.Domain;
using ConsoleApplication4.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication4.Commands
{
    class CreateParkingCommand:UndoableCommand
    {
        private IParkingFactory parkingFactory;
        private IParkingRepository parkingRepository;
        private string name;
        private int parkingPlaces;
        private int createdParkingId;

        public CreateParkingCommand(IParkingFactory parkingFactory, IParkingRepository parkingRepository, string name, int parkingPlaces)
        {
            this.parkingFactory = parkingFactory;
            this.parkingRepository = parkingRepository;
            this.name = name;
            this.parkingPlaces = parkingPlaces;
        }

        public void Execute()
        {
            IParking parking = parkingFactory.CreateParking(name, parkingPlaces);
            createdParkingId = parkingRepository.Save(parking);
        }

        public void Undo()
        {
            parkingRepository.Delete(createdParkingId);
        }
    }
}
