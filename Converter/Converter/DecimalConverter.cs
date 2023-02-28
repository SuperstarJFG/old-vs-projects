using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class DecimalConverter
    {
        int m_num;
        public DecimalConverter(int num)
        {
            m_num = num;
        }
        public string ToBinary()
        {
            string retval = "";
            int remainder = 0;
            int n = m_num;
            // 12/2=6r0 /2=3r0 /2=1r1 /2=0r1  =1100
            while (n > 0)
            {
                remainder = n % 2;
                n = n / 2;
                retval = remainder + retval;
            }
            return retval;
        }
    }
}