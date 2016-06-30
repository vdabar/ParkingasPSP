using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.Domain.Repositories;

namespace ConsoleApplication4.UI
{
    class ParkingListView :IParkingView
    {
    
            private ParkingRepository parkingRepository;

            public ParkingListView(ParkingRepository parkingRepository)
            {
                this.parkingRepository  = parkingRepository;
            }

            public void display()
            {
                var parkings = parkingRepository.FindAll();
                List<ParkingListItemView> list = new List<ParkingListItemView>();
                foreach (var parking in parkings)
                {
                    list.Add(new ParkingListItemView(parking.Id, parkingRepository));
                }
                foreach (var c in list)
                {
                    c.display();
                }
            }
        }
}
