﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Wheel
    {
        private string m_manufacturer;
        private float m_currentAirPressure;
        private readonly float m_maxAirPressure;

        public Wheel(float i_maxAirPressure)
        {
            m_maxAirPressure = i_maxAirPressure;
        }

        public string Manufacturer
        {
            get
            {
                return m_manufacturer;
            }
            set
            {
                m_manufacturer = value;
            }
        }

        public float MaxAirPressure
        {
            get
            {
                return m_maxAirPressure;
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

        public void Pump(float i_PreassureToAdd)
        {
            if(i_PreassureToAdd + m_currentAirPressure > m_maxAirPressure)
            {
                throw new ValueOutOfRangeException(0, m_maxAirPressure); //Check
            }
            else
            {
                m_currentAirPressure += i_PreassureToAdd;
            }
        }

    }
}
