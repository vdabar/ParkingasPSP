using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication4.Domain
{
    class CarWithCamper:CarSubject
    {


       

        public CarWithCamper(string name, string surname, string licensePlate)
        {
            Name = name;
            Surname = surname;
            LicensePlate = licensePlate;
        }
    }
}
