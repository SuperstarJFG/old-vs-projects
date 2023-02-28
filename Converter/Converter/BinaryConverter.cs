using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class BinaryConverter
    {
        int[] m_bits;
        public BinaryConverter(string num)
        {
            m_bits = new int[16];

            for (int i = 0; i < m_bits.Length; i++)
            {
                if (i < num.Length)
                {

                    if (num.Substring(num.Length - 1 - i, 1) == "1")
                    {
                        m_bits[i] = 1;
                    }
                }
            }
        }
        public int ToDecimal()
        {
            int tmp = 0;

            for (int i = 0; i < m_bits.Length; i++)
            {
                if (m_bits[i] != 0)
                {
                    tmp += (int)Math.Pow(2.0, (double)i);
                }
            }
            return tmp;
        }
        public string ToOctal()
        {
            string retval = "";
            int t = 0;
            for (int i = 0; i < m_bits.Length; i += 3)
            {
                t = m_bits[i];
                if (i + 1 < m_bits.Length)
                    t += 2 * m_bits[i + 1];
                if (i + 2 < m_bits.Length)
                    t += 4 * m_bits[i + 2];
                retval = t + retval;
            }
            return retval;
        }
        public override string ToString()
        {
            string tmp = "";

            for (int i = 0; i < m_bits.Length; i++)
            {
                if (m_bits[i] != 0)
                    tmp = "1" + tmp;
                else
                    tmp = "0" + tmp;
            }
            return tmp;
        }
    }
}
