using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarInventory
{
    class Car
    {
        public string make, colour;
        public int milage, year;

        public Car (string _make, string _colour, int _year, int _mileage)
        {
            make = _make;
            colour = _colour;
            year = _year;
            milage = _mileage;
        }
    }
}
