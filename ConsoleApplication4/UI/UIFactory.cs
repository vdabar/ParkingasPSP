using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.Controllers;
using ConsoleApplication4.Domain.Repositories;
using ConsoleApplication4.Commands;
using ConsoleApplication4.Domain;

namespace ConsoleApplication4.UI
{
    class UIFactory
    {
        public Controller CreateController(IParkingFactory parkingFactory, ParkingRepository parkingRepository, CarRepository carRepository, CommandHandler commandHandler)
        {
            return new Controller(new UIDefaultConsole(), parkingFactory,parkingRepository,carRepository,commandHandler);
        }
    }
}
