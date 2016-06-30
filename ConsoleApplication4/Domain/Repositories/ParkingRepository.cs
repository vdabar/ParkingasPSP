using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.Domain;
namespace ConsoleApplication4.Domain.Repositories
{
    class ParkingRepository:IParkingRepository
    {
        private int lastId = 1;
        private Dictionary<int, IParking> Parkings = new Dictionary<int, IParking>();

        public int Save(IParking parking)
        {
            if (parking.Id == 0)
            {
                parking.Id = lastId;
                lastId++;
            }

            Parkings.Add(parking.Id, parking);
            return parking.Id;
        }
        public IParking Find(int parkingId)
        {
            return Parkings[parkingId];
        }

        public ICollection<IParking> FindAll()
        {
            return Parkings.Values;
        }

        public void Delete(int parkingId)
        {
            Parkings.Remove(parkingId);
        }

    }
}
