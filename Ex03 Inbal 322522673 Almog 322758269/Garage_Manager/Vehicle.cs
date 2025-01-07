using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Garage_Manager
{
    public abstract class Vehicle
    {
        //- m_ModelName (string)
        //- m_LicenseNumber (string)
        //- m_RemainingEnergy (float)
        //- m_Wheel<T>:

        private readonly string m_ModelName;
        private readonly string m_LicenseNumber;
        private float m_RemainingEnergy;
        private Wheel[] m_Wheels;


        public Vehicle(int i_NumberOfWheels, float i_RemainingEnergy)
        {
            Wheel[] m_Wheels = new Wheel[i_NumberOfWheels];
            for (int i = 0; i < i_NumberOfWheels; i++)
            {
                m_Wheels[i] = new Wheel(i_RemainingEnergy);
            }

        }

        public string ModelName
        {
            get
            {
                return m_ModelName;
            }
        }

        public string LicenseNumber
        {
            get
            {
                return m_LicenseNumber;
            }
        }

        public float RemainingEnergy
        {
            get
            {
                return m_RemainingEnergy;
            }
            set
            {
                m_RemainingEnergy = value;
            }
        }

         
    }
}
