using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTest
{
    public class Program
    {
        //private static Vehicle _myVehicle;
        //private static MotorVehicle _myMotorVehicle;

        static void Main(string[] args)
        {

            Vehicle _myVehicle = Vehicle.CreateDefaultVehicle();
            MotorVehicle _myMotorVehicle = MotorVehicle.CreateDefaultMotorVehicle();

            DisplayMovement(_myMotorVehicle.Speed, _myMotorVehicle.Direction);
            _myMotorVehicle.Accelerate(20);
            DisplayMovement(_myMotorVehicle.Speed, _myMotorVehicle.Direction);
            _myMotorVehicle.Decelerate(30);
            DisplayMovement(_myMotorVehicle.Speed, _myMotorVehicle.Direction);

            DisplayMovement(_myVehicle.Speed, _myVehicle.Direction);
            _myVehicle.Accelerate(30);
            DisplayMovement(_myVehicle.Speed, _myVehicle.Direction);
            _myVehicle.Decelerate(40);
            DisplayMovement(_myVehicle.Speed, _myVehicle.Direction);
        }

        public static void DisplayMovement(int speed, string direction)
        {
            Console.WriteLine("Motor vehicle speed is {0} and direction is {1}", speed, direction);
        }
    }
}
