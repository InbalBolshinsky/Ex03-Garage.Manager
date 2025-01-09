using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class ElectricCar : ElectricVehicle
    {
        private eCarColors color;
        private eNumberOfDoors doors;

        public ElectricCar(string i_LicenseNumber, string i_Model, float i_RemainingBatteryTime, eCarColors i_Color, eCarDoors i_Doors) : base(i_LicenseNumber, i_Model, i_RemainingBatteryTime)
        {
            color = i_Color;
            doors = i_Doors;
        }



    }
}
