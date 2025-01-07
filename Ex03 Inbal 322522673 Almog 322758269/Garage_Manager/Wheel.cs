using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Manager
{
    public class Wheel
    {
        //- m_Manufacturer(string)
        //- m_CurrentAirPressure(float)
        //-m_MaxAirPressure(float)

        //+ (return value) Pump(i_PressureToAdd)

        private string m_manufacturer;
        private float m_currentAirPressure;
        private readonly float m_maxAirPressure;

        public Wheel(float i_maxAirPressure)
        {
            m_maxAirPressure = i_maxAirPressure;
        }

        public float MaxAirPressure
        {
            get
            {
                return m_maxAirPressure;
            }
            set
            {
                m_maxAirPressure = value;
            }
        }

        public float CurrentAirPressure
        {
            get
            {
                return m_currentAirPressure;
            }
            set
            {
                if (value > MaxAirPressure)
                {
                    throw new ValueOutOfRangeException(0, MaxAirPressure);
                }

                m_currentAirPressure = value;
            }
        }
        }



    }
}
