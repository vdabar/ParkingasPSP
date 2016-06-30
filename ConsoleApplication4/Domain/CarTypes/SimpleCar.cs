using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication4.Domain
{
    class SimpleCar : CarSubject
    {
       
        public SimpleCar( string name, string surname, string licensePlate)
        {
            Name = name;
            Surname = surname;
            LicensePlate = licensePlate;
        }
    }
}
