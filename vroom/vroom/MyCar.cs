using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vroom
{
    class MyCar : ICar
    {
        int m_speed;
        decimal m_Miles;
        int m_capacity;
        decimal m_gas;
        decimal m_MPG;

        public void Drive(int speed)
        {
            decimal tmpGas = speed / m_MPG;
            if (tmpGas > m_gas)
            {
                m_gas = 0;

                m_speed = 0;
                return;
            }
            m_speed = speed;
            m_gas -= (speed / m_MPG);
            m_Miles += tmpGas * m_MPG;
        }

        public decimal getGasLevel()
        {
            return m_gas / m_capacity;
        }

        public decimal getMiles()
        {
            return m_Miles;
        }

        public decimal getMPG()
        {
            return m_MPG;
        }

        public decimal getSpeed()
        {
            return m_speed;
        }

        public decimal getTankCapacity()
        {
            return m_capacity;
        }

        public void Refill(int amt)
        {
            m_gas += amt;
            if (m_gas > m_capacity)
            {
                m_gas = m_capacity;
            }
        }

        public void SetMPG(int m)
        {
            m_MPG = m;
        }

        public void SetTankCapacity(int c)
        {
            m_capacity = c;
        }

        public void STOP()
        {
            m_speed = 0;
        }
    }


}
