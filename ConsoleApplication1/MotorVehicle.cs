using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTest
{
    public class MotorVehicle : Vehicle
    {
        private int _fueltankSize;
        private int _fuelLevel;
        private int _engineRPM;
        private int _engineTemp;
        private int _coolantTemp;
        private int _coolantLevel;
        private double _batteryVoltage;

        public int FuelTankSize
        {
            get { return _fueltankSize; }
            set { _fueltankSize = value; }
        }

        public int FuelLevel
        {
            get { return _fuelLevel; }
            set { _fuelLevel = value; }
        }

        public int EngineRPM
        {
            get { return _engineRPM; }
            set { _engineRPM = value; }
        }

        public int EngineTemp
        {
            get { return _engineTemp; }
            set { _engineTemp = value; }
        }

        public int CoolantTemp
        {
            get { return _coolantTemp; }
            set { _coolantTemp = value; }
        }

        public int CoolantLevel
        {
            get { return _coolantLevel; }
            set { _coolantLevel = value; }
        }

        public double BatteryVoltage
        {
            get { return _batteryVoltage; }
            set { _batteryVoltage = value; }
        }

        private MotorVehicle(int numberofTires, int tirePressure, int speed, int fueltankSize, int fuelLevel,
    int engineRPM, int engineTemp, int coolantTemp, int coolantLevel, double batteryVoltage, string direction = null) : 
            base(numberofTires, tirePressure, speed, direction)
        {
            NumberOfTires = numberofTires;
            TirePressure = tirePressure;
            Speed = speed;
            Direction = direction;
            FuelTankSize = fueltankSize;
            FuelLevel = fuelLevel;
            EngineRPM = engineRPM;
            EngineTemp = engineTemp;
            CoolantTemp = coolantTemp;
            CoolantLevel = coolantLevel;
            BatteryVoltage = batteryVoltage;
        }

        public static MotorVehicle CreateDefaultMotorVehicle()
        {
            MotorVehicle motorVehicle = new MotorVehicle(4, 30, 0, 30, 15, 700, 170, 165, 10, 14.8);

            return motorVehicle;
        }
    }
}
