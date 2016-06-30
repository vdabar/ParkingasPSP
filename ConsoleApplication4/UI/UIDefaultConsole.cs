using ConsoleApplication4.Controllers;
using System;
using System.Net.Configuration;
using ConsoleApplication4.Domain.Repositories;

namespace ConsoleApplication4.UI
{
    class UIDefaultConsole :IUIConsole
    {
        private Controller _controller;
        


       

        public void Initialize(Controller controller)
        {
            _controller = controller;
            Console.WriteLine("\n1.AddCar\n" +
                             "2.AddParking\n" +
                             "3.ParkCar\n" +
                             "4.GetCarList\n" +
                             "5.GetParkingsList\n");
            string caseSwitch = Console.ReadLine();
            switch (caseSwitch)
            {
                case "1":              
                    CreateCar();
                    break;
                case "2":
                    CreateParking();
                    break;
                case "3":
                    AddCarToParking();
                    break;
                case "4":
                    GetCarList();
                    break;
                case "5":
                    GetParkingList();
                    break;


            }
        }

        public void CreateCar()
        {
            Console.WriteLine("Iveskite varda");
            string name = Console.ReadLine();
            Console.WriteLine("Iveskite Pavarde");
            string surname = Console.ReadLine();
            Console.WriteLine("Iveskite masinos numerius");
            string licensePlate = Console.ReadLine();
            _controller.CreateCar(name,surname,licensePlate);
            _controller.InitializeView();
        }

        public void CreateParking()
        {
            Console.WriteLine("Iveskite pavadinima");
            string name = Console.ReadLine();
            Console.WriteLine("iveskite vietu skaiciu");
            string parkingPlaces = Console.ReadLine();
            _controller.CreateParking(name,Int32.Parse(parkingPlaces));
            _controller.InitializeView();
        }

        public void AddCarToParking()
        {
            Console.WriteLine("Iveskite parkingo ID");
            int parkingID = int.Parse(Console.ReadLine());
            var model = _controller.GetParkingDetailsById(parkingID);
            model.display();
            Console.WriteLine("\nIveskite masinos ID");
            int carID = int.Parse(Console.ReadLine());
            


            _controller.ParkCar(carID,parkingID);           
            _controller.InitializeView();
        }

        public void GetCarList()
        {
            var model =_controller.getUnparkedCarList();
            model.display();
            _controller.InitializeView();
        }

        public void GetParkingList()
        {
            var model = _controller.GetParkingList();
            model.display();
            _controller.InitializeView();
        }

    }
}
