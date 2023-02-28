using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMatrix
{
    class Matrix
    {
        int m_n1;
        int m_n2;
        int m_n3;
        int m_n4;
        public Matrix(int n1, int n2, int n3, int n4)
        {
            m_n1 = n1;
            m_n2 = n2;
            m_n3 = n3;
            m_n4 = n4;
        }
        public override string ToString()
        {
            return "| " + m_n1 + " " + m_n2 + " |" + "\n" +
                   "| " + m_n3 + " " + m_n4 + " |";
        }
        public Matrix add(Matrix m2)
        {
            Matrix m3 = new Matrix(m_n1 + m2.m_n1, m_n2 + m2.m_n2,
                                   m_n3 + m2.m_n3, m_n4 + m2.m_n4);
            return m3;
        }
        public Matrix scalarMultiply(int n)
        {
            Matrix m3 = new Matrix(m_n1 * n, m_n2 * n,
                                   m_n3 * n, m_n4 * n);
            return m3;
        }
    }
}
