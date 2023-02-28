using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Binary
    {
        int[] m_bits;
        public Binary(int num)
        {
            m_bits = new int[8];
            int div = num;
            int rem = 0;
            int pos = 0;
            //wild (while) loop time!!
            while (div > 0)
            {
                rem = div % 2;
                div = div / 2;
                m_bits[pos] = rem;
                pos++;
            }
        }
        public Binary(int[] bits)
        {
            m_bits = new int[8];
            for (int i = 0; i < bits.Length; i++)
            {
                m_bits[i] = bits[i];
            }
        }
        public Binary Add(Binary other)
        {
            int[] answer = new int[8];
            for (int i = 0; i < m_bits.Length; i++)
            {
                int sum = m_bits[i] + other.m_bits[i] + answer[i];
                if (sum < 2)
                    answer[i] = sum;
                if (sum == 2)
                {
                    answer[i] = 0;
                    answer[i + 1] = 1;
                }
                if (sum == 3)
                {
                    answer[i] = 1;
                    answer[i + 1] = 1;
                }
            }
            return new Binary(answer);
        }
        public Binary And(Binary other)
        {
            int[] answer = new int[8];
            for (int i = 0; i < m_bits.Length; i++)
            {
                answer[i] = m_bits[i] * other.m_bits[i];
            }
            return new Binary(answer);
        }
        public Binary Or(Binary other)
        {
            int[] answer = new int[8];
            for (int i = 0; i < m_bits.Length; i++)
            {
                answer[i] = m_bits[i] + other.m_bits[i];
                if (answer[i] > 1) answer[i] = 1;
            }
            return new Binary(answer);
        }
        public Binary Not()
        {
            int[] answer = new int[8];
            for (int i = 0; i < m_bits.Length; i++)
            {
                answer[i] = m_bits[i] - 1;
                if (answer[i] < 0) answer[i] = 1;
            }
            return new Binary(answer);
        }
        public Binary ShiftLeft()
        {
            int[] answer = new int[8];
            for (int i = 1; i < m_bits.Length; i++)
            {
                answer[i] = m_bits[i-1];
            }
            return new Binary(answer);
        }
        public override string ToString()
        {
            string retval = "";
            for (int i = 0; i < m_bits.Length; i++)
            {
                retval = m_bits[i] + retval;
            }
            return retval.ToString();
        }

    }
}
