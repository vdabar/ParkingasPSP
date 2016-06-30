using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.Domain;
using ConsoleApplication4.Domain.Repositories;

namespace ConsoleApplication4.Commands
{
    class CreateCarCommand:UndoableCommand
    {
        private IParkingFactory parkingFactory;
        private CarRepository carRepository;
        public string name;
        public string surname;
        public string licensePlate;
        private int createdCarId;

        public CreateCarCommand(CarRepository carRepository,IParkingFactory parkingFactory,string name, string surname, string licensePlate)
        {
            this.carRepository = carRepository;
            this.parkingFactory = parkingFactory;
            this.name = name;
            this.surname = surname;
            this.licensePlate = licensePlate;

        }
        public void Execute()
        {
            CarSubject car = parkingFactory.CreateCar(name, surname, licensePlate);
            createdCarId = carRepository.Save(car);
        }

        public void Undo()
        {
            carRepository.Delete(createdCarId);
        }
    }
}
