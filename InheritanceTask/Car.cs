using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    class Car : Vehicle
    {
        public Car(string name, int maxSpeed) : base(name, maxSpeed)
        {
        }

        public void SetName(string value)
        {
            Name = value;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
