using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication4.Domain
{
    class Camping:ParkingSubject,IParking
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool RegularParking { get; set; }
        private int parkingSpaces;
        
        public Camping(string name,  int parkingSpaces) : base(parkingSpaces)
        {
            Name = name;
            this.parkingSpaces = parkingSpaces;
        }
        
    }
}
