using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    class Vehicle
    {
        private readonly string name;
        private readonly int maxSpeed;

        protected string Name { get; set; }
        public int MaxSpeed { get; }

        public Vehicle(string name, int maxSpeed)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
        }
    }
}
