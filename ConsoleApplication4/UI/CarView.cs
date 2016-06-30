using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.Domain;

namespace ConsoleApplication4.UI
{
    abstract class CarView :ICarObserver,ICarView
    {
        private int _id;

        protected CarView(int id)
        {
            _id = id;
        }

        public abstract void display();
        public abstract void UpdateCar(CarSubject car);
    }
}
