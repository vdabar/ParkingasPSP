using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.Commands;
using ConsoleApplication4.Controllers;
using ConsoleApplication4.Domain;
using ConsoleApplication4.Domain.Repositories;
using ConsoleApplication4.UI;

namespace ConsoleApplication4
{
    class Program
    {
        private static IParkingRepository parkingRepository;

        static void Main(string[] args)
        {
         var uifact = new UIFactory();
            CarRepository carRepository= new CarRepository();
            IParkingFactory parkingFactory = new HugeFactory();
            CommandHandler commandHandler = new CommandHandler();
            ParkingRepository parkingRepository = new ParkingRepository();
            var controller = uifact.CreateController(parkingFactory, parkingRepository, carRepository, commandHandler);
            controller.InitializeView();

        }
    }
}
