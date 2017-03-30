using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTest
{
    public class Vehicle
    {
        private int _numberofTires;
        private int _tirePressure;
        private int _speed;
        private string _direction;

        public int NumberOfTires
        {
            get { return _numberofTires; }
            set { _numberofTires = value; }
        }

        public int TirePressure
        {
            get { return _tirePressure; }
            set { _tirePressure = value; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public string Direction
        {
            get
            {
                if (_speed < 0) { return _direction = "reverse"; }
                else if (_speed == 0) { return _direction = "stationary"; }
                else { return _direction = "forward"; }
            }
            set { _direction = value; }
        }

        public void Accelerate(int mph)
        {
            _speed += mph;
        }

        public void Decelerate(int mph)
        {
            _speed -= mph;
        }

        public Vehicle(int numberofTires, int tirePressure, int speed, string direction = null)
        {
            NumberOfTires = numberofTires;
            TirePressure = tirePressure;
            Speed = speed;
            Direction = direction;
        }

        public static Vehicle CreateDefaultVehicle()
        {
            Vehicle vehicle = new VehicleTest.Vehicle(4, 30, 0);

            return vehicle;
        }
    }
}
