using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.Domain;

namespace ConsoleApplication4.Domain.Repositories
{
    class CarRepository:ICarRepository
    {
        private int lastId = 1;
        private Dictionary<int, CarSubject> Cars = new Dictionary<int, CarSubject>();

        public int Save(CarSubject car)
        {
            if (car.Id == 0)
            {
                car.Id = lastId++;
            }

            Cars.Add(car.Id, car);
            return car.Id;
        }
        public CarSubject Find(int parkingId)
        {
            return Cars[parkingId];
        }

        public ICollection<CarSubject> FindAll()
        {
            return Cars.Values;
        }

        public void Delete(int carId)
        {
            Cars.Remove(carId);
        }

    }
}
