using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.Domain.Repositories;

namespace ConsoleApplication4.UI
{
    class CarListView : IParkingView
    {
        private CarRepository carRepository;

        public CarListView(CarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public void display()
        {
            var cars = carRepository.FindAll();
            List<CarListItemView> list = new List<CarListItemView>();
            foreach (var car in cars)
            {
                list.Add(new CarListItemView(car.Id,carRepository));       
            }
            foreach (var c in list)
            {
                c.display();
            }
        }

    }
}
