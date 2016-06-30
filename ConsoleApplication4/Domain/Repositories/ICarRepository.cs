using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.Domain;

namespace ConsoleApplication4.Domain.Repositories
{
    interface ICarRepository
    {
        int Save(CarSubject car);
        CarSubject Find(int parkingId);
        ICollection<CarSubject> FindAll();
        void Delete(int parkingId);
    }
}
