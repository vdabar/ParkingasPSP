using ConsoleApplication4.Commands;
using ConsoleApplication4.Domain;
using ConsoleApplication4.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.UI;

namespace ConsoleApplication4.Controllers
{
    class Controller 
    {
        private IParkingFactory parkingFactory;

        private ParkingRepository parkingRepository;

        private CarRepository carRepository;

        private CommandHandler commandHandler;

        private UIDefaultConsole _view;

        


        public Controller(UIDefaultConsole _view,  IParkingFactory parkingFactory, ParkingRepository parkingRepository, CarRepository carRepository,  CommandHandler commandHandler)
        {
            this._view = _view;
            this.parkingRepository = parkingRepository;
            this.parkingFactory = parkingFactory;
            this.carRepository = carRepository;
            this.commandHandler = commandHandler;
           
        }

        public void InitializeView()
        {
            _view.Initialize(this);
        }

        public void UndoLastOperation()
        {
            commandHandler.Undo();
        }

        public void CreateParking(string name, int parkingPlaces)
        {
            commandHandler.Execute(new CreateParkingCommand(parkingFactory, parkingRepository, name, parkingPlaces));
        }

        public void CreateCar(string name, string surname, string licensePlate)
        {
            var command = new CreateCarCommand(carRepository,parkingFactory,name,surname,licensePlate);
            commandHandler.Execute(command);
        }

        public void ParkCar(int carID, int parkingID)
        {
            
            commandHandler.Execute(new ParkCarCommand(parkingRepository,carRepository,carID,parkingID));
        }

        public ICarView GetCarDetailsById(int id)
        {
            return new CarListItemView(id, carRepository);
        }
        public IParkingView GetParkingDetailsById(int id)
        {
            return new ParkingListItemView(id, parkingRepository);
        }


        public IParkingView getUnparkedCarList()
        {
            return new CarListView(carRepository);
        }
        public IParkingView GetParkingList()
        {
            return new ParkingListView(parkingRepository);
        }
    }
}
