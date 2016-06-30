using ConsoleApplication4.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using ConsoleApplication4.Domain.Repositories;
 

namespace ConsoleApplication4.Commands
{
    class ParkCarCommand : UndoableCommand
    {
        private ParkingRepository parkingRepository;
        private CarRepository carRepository;
        private int carId;
        int parkingId;

        public ParkCarCommand(ParkingRepository parkingRepository, CarRepository carRepository,int carId, int parkingId)
        {
            this.parkingRepository = parkingRepository;
            this.carRepository = carRepository;
            this.carId = carId;
            this.parkingId = parkingId;

        }
        public void Execute()
        {
            IParking whereToPark = parkingRepository.Find(parkingId);
            CarSubject carToPark = carRepository.Find(carId);
            whereToPark.SetCarToParking(carToPark);
            carToPark.IsParked = true;
            
        }

        public void Undo()
        {
            IParking whereToPark = parkingRepository.Find(parkingId);
            CarSubject carToPark = carRepository.Find(carId);
            whereToPark.RemoveCarfromParking(carToPark);
            carToPark.IsParked = false;

        }
    }
}
