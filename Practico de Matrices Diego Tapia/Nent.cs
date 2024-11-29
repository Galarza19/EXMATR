using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_de_Matrices_Diego_Tapia
{
    class Nent
    {
        private int n;
        public Nent()
        {
            n = 0;
        }
        public void Cargar(int dato)
        {
            n = dato;
        }
        public bool VerifPrim()
        {
            bool sw = false;
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    c++;
                }
            }
            if (c == 2)
                sw = true;
            return sw;
        }
        public bool VerifFibo()
        {
            int a, b, c;
            a = -1; b = 1; c = a + b;
            bool sw = false;
            while (c <= n)
            {
                if (c == n)
                {
                    sw = true;
                }
                a = b;
                b = c;
                c = a + b;


            }
            return sw;
        }
    }
}

