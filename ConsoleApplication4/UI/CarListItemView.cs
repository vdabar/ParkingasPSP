using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.Domain;
using ConsoleApplication4.Domain.Repositories;

namespace ConsoleApplication4.UI
{
    class CarListItemView:CarView
    {
        private string name;
        private string surname;
        private string licenseplate;
        private bool isParked;
        private int _id;

        private CarRepository _carRepository;

        public CarListItemView(int id, CarRepository carRepository):base(id)
        {
            _carRepository = carRepository;
            _id = id;
            
        }

        public override void display()
        {
            Initialize();
            Console.Write("id: " + _id +
                          " | vardas: " + name +
                          " | pavarde: " + surname+
                          " | numeriai: "+licenseplate+
                          " | Priparkuota: " + isParked+
                          "\n");
        }

        public override void UpdateCar(CarSubject car)
        {            
            name = car.Name;
            surname = car.Surname;
            licenseplate = car.LicensePlate;
            isParked = car.IsParked;
        }

        private void Initialize()
        {
            var car = _carRepository.Find(_id);
            car.Attach(this);
            UpdateCar(car);
        }
    }
}
