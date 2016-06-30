using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.Domain;

namespace ConsoleApplication4.Domain.Repositories
{
    interface IParkingRepository
    {
        int Save(IParking parking);
        IParking Find(int parkingId);
        ICollection<IParking> FindAll();
        void Delete(int parkingId);
        
    }
}
