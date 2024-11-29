using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_de_Matrices_Diego_Tapia
{
    class Vector
    {
        private int n;
        private int[] v;
        private int MAX = 201;
        public Vector()
        {
            n = 0; v = new int[MAX];
        }
        public void Push(int dato)
        {
            n++;
            v[n] = dato;
        }
        public int DescargarDato(int i)
        {
            return v[i];
        }
        public void Burbuja()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
        }
        public string Descargar()
        {
            string s = "";
            for (int i = 1; i <= n; i++)
            {
                s = s + v[i] + " | ";
            }
            return s;
        }
    }
}
