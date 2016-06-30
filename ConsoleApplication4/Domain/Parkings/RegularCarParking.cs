using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication4.Domain
{
    class RegularCarParking:ParkingSubject,IParking
    {
        
        
        public int Id { get; set; }

        public RegularCarParking(string name,  int parkingSpaces) : base(parkingSpaces)
        {
            Name = name;
        }
       
    }
}
