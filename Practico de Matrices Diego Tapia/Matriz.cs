using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_de_Matrices_Diego_Tapia
{
    class Matriz
    {
        const int MAXF = 50;
        const int MAXC = 50;
        private int[,] x;
        private int f, c;

        public Matriz()
        {
            x = new int[MAXF, MAXC];
            f = 0;
            c = 0;
        }
        public void Cargar(int nf, int nc, int a, int b)
        {
            int f1, c1;
            Random r = new Random();
            f = nf; c = nc;
            for (f1 = 1; f1 <= f; f1++)
                for (c1 = 1; c1 <= c; c1++)
                {
                    x[f1, c1] = r.Next(a, b + 1);
                }
        }

        public string Descargar()
        {
            int f1, c1;
            string s = "";
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                    s = s + x[f1, c1] + "\x009";
                s = s + "\x00d" + "\x00a";
            }
            return s;
        }

        //Primera parte del Practico 
        //Ejercicio N1. Contar elementos de la matriz que se repiten (Frecuencia).
        public int Frec(int fil, int col, int ele)
        {
            int fr = 0;
            int col1 = col;
            for (int f1 = fil; f1 <= f; f1++)
            {
                for (int c1 = col1; c1 <= c; c1++)
                {
                    if (ele == x[f1, c1])
                    {
                        fr++;
                    }
                }
                col1 = 1;//Arreglo ya que al terminar el for de c1, empieza empezaba en col, pero con el arreglo este ya no empieza en col, empieza en 1 "depende del recorrido"
            }
            return fr;
        }
        //En esta funcion introduzco 3 datos , fila columna y un elemento
        // recorro la matriz verificando la frecuencia del elemneto introducido
        public int Ejercicio1()
        {
            int r = 0;
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    if ((Frec(1, 1, x[f1, c1]) > 1))
                    {
                        if (Frec(f1, c1, x[f1, c1]) == 1)
                            r++;
                    }
                }
            }
            return r;
        }
        //Inicio bscando la frecuencia desde la fila 1, columna, si se encuentra elementos repetidos
        //empiezo buscando mas frecuencia pero desde el elemento repetido, todo se suma a r que lanza la frecuencia.

        // Ejercicio 2. Cargar Fibonnacci en forma de pim pom

        public void Ejercicio2(int fil, int col)
        {
            f = fil; c = col;
            int a, b, z;
            a = -1; b = 1; z = a + b;
            bool sw = true;
            for (int f1 = 1; f1 <= f; f1++)
            {
                if (sw)
                {
                    for (int c1 = 1; c1 <= c; c1++)
                    {
                        x[f1, c1] = z;
                        a = b; b = z; z = a + b;
                    }
                }
                else
                {
                    for (int c1 = c; c1 >= 1; c1--)
                    {
                        x[f1, c1] = z;
                        a = b; b = z; z = a + b;
                    }
                }
                sw = !sw;

            }

        }
        //// ejercicio 3 Verificar si las filas estan ordenadas en forma aAscendente
        public bool Ejercicio3()
        {
            bool sw = true;

            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    for (int c2 = c1; c2 <= c; c2++)
                    {
                        if (x[f1, c1] > x[f1, c2])
                        {
                            sw = false; break;
                        }
                    }
                    if (sw == false)
                        break;
                }
                if (sw == false)
                    break;
            }

            return sw;
        }
        //Ejercicio  4  ENcontrar Frecuencia y aumentar una columna
        public int FrecCol(int f1, int ele)
        {
            int fr = 0;
            for (int c1 = 1; c1 <= c; c1++)
            {
                if (ele == x[f1, c1])
                    fr++;

            }
            return fr;
        }
        public void Ejercicio4()
        {

            for (int f1 = 1; f1 <= f; f1++)
            {
                int fr = FrecCol(f1, x[f1, 1]);
                int ele = x[f1, 1];
                for (int c1 = 1; c1 <= c; c1++)
                {
                    if (FrecCol(f1, x[f1, c1]) > fr)
                    {
                        ele = x[f1, c1];
                        fr = FrecCol(f1, x[f1, c1]);
                    }
                }
                x[f1, c + 1] = ele;
            }
            c++;
        }
        //Ejercicio5 Verificar si toda la matrix esta ordenada en Rigor 1. 1++
        public void InterEle(int f1, int c1, int f2, int c2)
        {
            int aux = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }
        public bool Ejercicio5()
        {
            /*   x[1, 1] = 10; x[1, 2] = 11; x[1, 3] = 12;
               x[2, 1] = 7; x[2, 2] = 8; x[2, 3] = 9;
               x[3, 1] = 4; x[3, 2] = 5; x[3, 3] = 6;
               x[4, 1] = 1; x[4, 2] = 2; x[4, 3] = 3;
               f = 4; c = 3;
            */
            bool sw = true;
            for (int f1 = f; f1 >= 1; f1--)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    int fx = f1; int cx = c1;
                    for (int f2 = fx; f2 >= 1; f2--)
                    {
                        for (int c2 = cx; c2 <= c; c2++)
                        {
                            if (x[f1, c1] > x[f2, c2])
                                sw = false;
                        }
                        cx = 1;
                    }

                }

            }
            return sw;
        }
        // Ejercicio 6. Verificar si una Matrix esta ncluida en otra.
        public bool busele(int ele)
        {
            bool sw = false;
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    if (x[f1, c1] == ele)
                        sw = true; ;

                }

            }
            return sw;
        }

        public bool Ejericio6(Matriz x2)
        {
            bool sw = true;
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    if (!x2.busele(x[f1, c1]))
                        sw = false;

                }

            }
            return sw;
        }

        //Ejercicio 7. Segmentar filas en pares e impares.
        public void Bpar(int f1)
        {
            for (int c1 = 1; c1 <= c; c1++)
            {
                if (x[f1, c1] % 2 == 0)
                {
                    for (int c2 = c1; c2 <= c; c2++)
                    {
                        if (x[f1, c2] % 2 == 0)
                        {
                            if (x[f1, c1] > x[f1, c2])
                                InterEle(f1, c1, f1, c2);
                        }
                    }
                }
            }
        }
        public void BImpar(int f1)
        {
            for (int c1 = 1; c1 <= c; c1++)
            {
                if (x[f1, c1] % 2 != 0)
                {
                    for (int c2 = c1; c2 <= c; c2++)
                    {
                        if (x[f1, c2] % 2 != 0)
                        {
                            if (x[f1, c1] > x[f1, c2])
                                InterEle(f1, c1, f1, c2);
                        }
                    }
                }
            }
        }
        public void Ejercicio7()
        {
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    for (int c2 = c1; c2 <= c; c2++)
                    {
                        if (x[f1, c1] % 2 != 0)
                        {
                            InterEle(f1, c1, f1, c2);
                        }
                    }
                }
                Bpar(f1);
                BImpar(f1);
            }
        }

        //Ejercicio 8. Ordenar por primos
        public void InterFil(int f1, int f2)
        {
            for (int c1 = 1; c1 <= c; c1++)
            {
                InterEle(f1, c1, f2, c1);
            }

        }
        public int CantPrim(int f1)
        {
            int cant = 0;
            Nent n1 = new Nent();
            for (int c1 = 1; c1 <= c; c1++)
            {
                n1.Cargar(x[f1, c1]);
                if (n1.VerifPrim())
                {
                    cant = x[f1, c1];
                }

            }
            return cant;
        }
        public void Ejercicio8()
        {
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int f2 = f1; f2 <= f; f2++)
                {
                    if (CantPrim(f1) > CantPrim(f2))
                        InterFil(f1, f2);
                }
                x[f1, c + 1] = CantPrim(f1);
            }
            c++;//Corregir el funcionamiento
        }

        //Ejercicio 9
        public void Ejercicio9(ref string s)
        {
            Vector v1 = new Vector();
            for (int c1 = c; c1 >= 1; c1--)
            {
                for (int f1 = f; f1 >= 1; f1--)
                {
                    v1.Push(x[f1, c1]);
                }
            }
            v1.Burbuja();
            int i = 1;
            for (int c1 = c; c1 >= 1; c1--)
            {
                for (int f1 = f; f1 >= 1; f1--)
                {
                    x[f1, c1] = v1.DescargarDato(i);
                    i++;
                }
            }
            s = v1.Descargar();
        }
        //Ejercicio 10
        public void RecColUp(int c1, int fi, int ff)
        {
            for (int f1 = fi; f1 <= ff - 1; f1++)
            {
                x[f1, c1] = x[f1 + 1, c1];
            }
        }
        public void RecColDown(int c1, int fi, int ff)
        {
            for (int f1 = ff; f1 >= fi + 1; f1--)
            {
                x[f1, c1] = x[f1 - 1, c1];
            }
        }
        public void RecFilLeft(int f1, int ci, int cf)
        {
            for (int c1 = ci; c1 <= cf - 1; c1++)
            {
                x[f1, c1] = x[f1, c1 + 1];
            }
        }
        public void RecFilRight(int f1, int ci, int cf)
        {
            for (int c1 = cf; c1 >= ci + 1; c1--)
            {
                x[f1, c1] = x[f1, c1 - 1];
            }
        }
        public void Ejercicio10()
        {
            int fi = 1; int ci = 1; int ff = f; int cf = c;
            int p = x[1, 1];
            int pivote;
            for (int i = 1; i < (f / 2) + 1; i++)
            {
                pivote = x[fi, ci];
                RecColUp(ci, fi, ff);
                RecFilLeft(ff, ci, cf);
                RecColDown(cf, fi, ff);
                RecFilRight(fi, ci, cf);
                fi++; ff--;
                ci++; cf--;

                x[i, i + 1] = pivote;
            }

        }

        //Segunda Parte del Pracico.

        // Ejercicio 1. ordenar por frecuencia
        public int FrecRango(int fi, int ff, int ci, int cf, int ele)
        {
            int fr = 0;
            for (int c1 = cf; c1 >= ci; c1--)
            {
                for (int f1 = fi; f1 <= ff; f1++)
                {
                    if (ele == x[f1, c1])
                        fr++;

                }

            }
            return fr;
        }

        public void busNum(int fi, int ff, int ci, int cf, int ele, ref int fil, ref int col)
        {
            bool sw = true;
            for (int c1 = ci; c1 <= cf; c1++)
            {
                for (int f1 = ff; f1 >= fi; f1--)
                {
                    if (ele == x[f1, c1])
                    {
                        fil = f1;
                        col = c1;
                        sw = false;
                        break;
                    }
                }
                if (sw == false)
                    break;
            }

        }
        public void BFrec1(int fi, int ff, int ci, int cf)
        {
            for (int c1 = cf; c1 >= ci; c1--)
            {
                for (int f1 = fi; f1 <= ff; f1++)
                {
                    if (FrecRango(fi, ff, ci, cf, x[f1, c1]) == 1)
                    {
                        int cx = c1; int fx = f1;
                        for (int c2 = cx; c2 >= ci; c2--)
                        {
                            for (int f2 = fx; f2 <= ff; f2++)
                            {
                                if (FrecRango(fi, ff, ci, cf, x[f2, c2]) == 1)
                                {
                                    if (x[f1, c1] > x[f2, c2])
                                    {
                                        InterEle(f1, c1, f2, c2);
                                    }
                                }
                            }
                            fx = fi;
                        }

                    }
                }

            }


        }
        public void EJERCICIO1(int fi, int ff, int ci, int cf)
        {
            /* 
               x[1, 1] = 4;  x[1, 2] = 11; x[1, 3] = 12; x[1, 4] = 13;
               x[2, 1] = 3;  x[2, 2] = 4;  x[2, 3] = 4;  x[2, 4] = 4;
               x[3, 1] = 2;  x[3, 2] = 3;  x[3, 3] = 3;  x[3, 4] = 3;
               x[4, 1] = 1;  x[4, 2] = 1;  x[4, 3] = 2;  x[4, 4] = 2;
               f = 4; c = 4;*/
            /*   
                x[1,1]=8; x[1,2]=8; x[1,3]=4;  x[1,4]=10;	
                x[2,1]=6; x[2,2]=5; x[2,3]=10; x[2,4]=1;	
                x[3,1]=8; x[3,2]=4; x[3,3]=1;  x[3,4]=10;	
                x[4,1]=1; x[4,2]=3;	x[4,3]=8;	x[4,4]=1;	
                f = 4; c = 4;

             */
            //BubblesRango(fi, ff, ci, cf);
            for (int c1 = cf; c1 >= ci; c1--)
            {
                for (int f1 = fi; f1 <= ff; f1++)
                {
                    int cx = c1; int fx = f1;
                    for (int c2 = cx; c2 >= ci; c2--)
                    {
                        for (int f2 = fx; f2 <= ff; f2++)
                        {
                            if ((FrecRango(fi, ff, ci, cf, x[f1, c1]) < FrecRango(fi, ff, ci, cf, x[f2, c2])))
                            {
                                InterEle(f1, c1, f2, c2);
                            }
                        }
                        fx = fi;
                    }


                }

            }
            PonerEleRep(fi, ff, ci, cf);
            BFrec1(fi, ff, ci, cf);

        }

        //////////////////////////////
        public void PonerEleRep(int fi, int ff, int ci, int cf)
        {
            bool sw = false; int i = 1; int aux = 0;
            int fil = 0; int col = 0;
            for (int c1 = cf; c1 >= ci; c1--)
            {
                for (int f1 = fi; f1 <= ff; f1++)
                {

                    if (sw == false)
                    {
                        aux = x[f1, c1];//gaurda el pivote
                    }

                    if (sw == true)
                    {
                        if (i < FrecRango(fi, ff, ci, cf, aux))//solo busca lo  necesario
                        {
                            fil = 0; col = 0;
                            busNum(fi, ff, ci, cf, aux, ref fil, ref col);
                            InterEle(fil, col, f1, c1);
                            i++;//cada que intercambia i++
                        }
                        else
                        {

                            sw = false;//cambia para obtener la nueva  variable 
                            i = 1;//reinicia contador
                            f1--;/// arreglo
                        }
                    }
                    else
                    {
                        sw = true;
                    }
                }
            }
        }



        //EJERCICIO 2 Ordenar en forma Zenozoidal
        public void EJERCICIO2()
        {
            bool sw = true;
            for (int c1 = 1; c1 <= c; c1++)
            {
                if (sw == true)
                {
                    for (int f1 = f; f1 >= 1; f1--)
                    {
                        int fx = f1; int cx = c1;
                        for (int c2 = cx; c2 <= c; c2++)
                        {
                            for (int f2 = fx; f2 >= 1; f2--)
                            {
                                if (x[f1, c1] > x[f2, c2])
                                {
                                    InterEle(f1, c1, f2, c2);
                                }

                            }
                            fx = f;
                        }
                    }
                    sw = false;
                }
                else
                {
                    for (int f1 = 1; f1 <= f; f1++)
                    {
                        int fx = f1; int cx = c1;
                        for (int c2 = cx; c2 <= c; c2++)
                        {
                            for (int f2 = fx; f2 <= f; f2++)
                            {
                                if (x[f1, c1] > x[f2, c2])
                                {
                                    InterEle(f1, c1, f2, c2);
                                }

                            }
                            fx = 1;
                        }
                    }
                    sw = true;
                }

            }
        }

        /////////////Ejercicio3

        public int CantFib(int fi, int ci)
        {
            int cant = 0;
            Nent n1 = new Nent();
            for (int f1 = fi; f1 >= 1; f1--)
            {
                for (int c1 = ci; c1 <= c; c1++)
                {
                    n1.Cargar(x[f1, c1]);
                    if (n1.VerifFibo())
                        cant++;


                }
                ci = 1;
            }
            return cant;
        }
        public int CantNoFib(int fi, int ci)
        {
            int cant = 0;
            Nent n1 = new Nent();
            for (int f1 = fi; f1 >= 1; f1--)
            {
                for (int c1 = ci; c1 <= c; c1++)
                {
                    n1.Cargar(x[f1, c1]);
                    if (!n1.VerifFibo())
                        cant++;


                }
                ci = 1;
            }
            return cant;
        }
        public void PosFib(int fi, int ci, ref int fil, ref int col)
        {
            bool sw = true;
            Nent n1 = new Nent();
            for (int f1 = fi; f1 >= 1; f1--)
            {
                for (int c1 = ci; c1 <= c; c1++)
                {
                    n1.Cargar(x[f1, c1]);
                    if (n1.VerifFibo())
                    {
                        fil = f1; col = c1;
                        sw = false; break;
                    }


                }
                ci = 1;
                if (sw == false)
                { break; }
            }


        }
        public void PosNoFib(int fi, int ci, ref int fil, ref int col)
        {
            bool sw = true;
            Nent n1 = new Nent();
            for (int f1 = fi; f1 >= 1; f1--)
            {
                for (int c1 = ci; c1 <= c; c1++)
                {
                    n1.Cargar(x[f1, c1]);
                    if (!n1.VerifFibo())
                    {
                        fil = f1; col = c1;
                        sw = false; break;
                    }


                }
                ci = 1;
                if (sw == false)
                { break; }
            }
        }


        public void EJERCICIO3()
        {

            int fil = 0; int col = 0; bool sw2 = true;
            for (int f1 = f; f1 >= 1; f1--)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {

                    if ((CantFib(f1, c1) > 0) && (sw2 == true))
                    {


                        PosFib(f1, c1, ref fil, ref col);
                        InterEle(f1, c1, fil, col);


                    }
                    if ((CantNoFib(f1, c1) > 0) && (sw2 == false))
                    {


                        PosNoFib(f1, c1, ref fil, ref col);
                        InterEle(f1, c1, fil, col);


                    }
                    sw2 = !sw2;
                }

            }
        }

        /// EJERCICIO 4

        public void EJERCICIO4()
        {
            for (int f1 = 1; f1 <= f - 1; f1++)
            {
                for (int c1 = f1 + 1; c1 <= c; c1++)
                {
                    for (int f2 = 1; f2 <= f - 1; f2++)
                    {
                        for (int c2 = f2 + 1; c2 <= c; c2++)
                        {
                            if (x[f1, c1] < x[f2, c2])
                            {
                                InterEle(f1, c1, f2, c2);
                            }
                        }
                    }
                }
            }
        }

        //EJERCICIO 5}
        public void EJERCICIO5()
        {
            int a, b;
            bool sw, sw1;
            for (int c1 = 1 + 1; c1 <= c; c1++)
            {
                for (int f1 = f; f1 >= f - c1 + 1 + 1; f1--)
                {
                    for (int c2 = 1 + 1; c2 <= c; c2++)
                    {
                        for (int f2 = f; f2 >= f - c2 + 1 + 1; f2--)
                        {
                            a = x[f1, c1];
                            b = x[f2, c2];
                            sw = (x[f1, c1] % 2 == 0);
                            sw1 = (x[f2, c2] % 2 == 0);
                            if ((sw && !sw1) || (!sw && !sw1 && a < b) || (sw && sw1 && a < b))
                            {
                                InterEle(f1, c1, f2, c2);
                            }
                        }
                    }


                }
            }
        }
        //////////////EJERCICIO 6
        public void EJERCICIO6()
        {
            int aux = f;
            for (int c1 = 1; c1 <= c; c1++, aux--)
            {
                int aux2 = aux;
                for (int c2 = c1; c2 <= c; c2++, aux2--)
                {
                    if (x[aux, c1] < x[aux2, c2])
                    { InterEle(aux, c1, aux2, c2); }

                }


            }

        }

        ///// public void InterEle(int f1, int c1, int f2, int c2)
        ///  {
        // int aux = x[f1, c1];
        //  x[f1, c1] = x[f2, c2];
        //  x[f2, c2] = aux;
        /// }
        public void Ordenamiento1()
        {
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    for (int f2 = 1; f2 <= f; f2++)
                    {
                        for (int c2 = 1; c2 <= c; c2++)
                        {
                            if (x[f1, c1] < x[f2, c2])
                            {
                                InterEle(f1, c1, f2, c2);
                            }

                        }
                    }
                }
            }
        }

        // Ordenamiento 2
        public void Ordenamiento2()
        {
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = c; c1 >= 1; c1--)
                {
                    for (int f2 = 1; f2 <= f; f2++)
                    {
                        for (int c2 = c; c2 >= 1; c2--)
                        {
                            if (x[f1, c1] < x[f2, c2])
                            {
                                InterEle(f1, c1, f2, c2);
                            }

                        }
                    }
                }
            }
        }


        //Ordenamiento 3
        public void Ordenamiento3()
        {
            for (int c1 = 1; c1 <= c; c1++)
            {
                for (int f1 = f; f1 >= 1; f1--)
                {
                    for (int c2 = 1; c2 <= c; c2++)
                    {
                        for (int f2 = f; f2 >= 1; f2--)
                        {
                            if (x[f1, c1] < x[f2, c2])
                            {
                                InterEle(f1, c1, f2, c2);
                            }

                        }
                    }
                }
            }
        }

        //Ordenamiento 4
        public void Ordenamiento4()
        {
            for (int c1 = c; c1 >= 1; c1--)
            {
                for (int f1 = f; f1 >= 1; f1--)
                {
                    for (int c2 = c; c2 >= 1; c2--)
                    {
                        for (int f2 = f; f2 >= 1; f2--)
                        {
                            if (x[f1, c1] < x[f2, c2])
                            {
                                InterEle(f1, c1, f2, c2);
                            }

                        }
                    }
                }
            }
        }

        //Triangulares

        public void Triangular1()
        {
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= f1; c1++)
                {
                    for (int f2 = 1; f2 <= f; f2++)
                    {
                        for (int c2 = 1; c2 <= f2; c2++)
                        {
                            if (x[f1, c1] < x[f2, c2])
                            {
                                InterEle(f1, c1, f2, c2);
                            }

                        }
                    }
                }
            }
        }

        // Triangular 2. Sin diafonal principal
        public void Triangular2()
        {
            for (int f1 = 1 + 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= f1 - 1; c1++)
                {
                    for (int f2 = 1 + 1; f2 <= f; f2++)
                    {
                        for (int c2 = 1; c2 <= f2 - 1; c2++)
                        {
                            if (x[f1, c1] < x[f2, c2])
                            {
                                InterEle(f1, c1, f2, c2);
                            }

                        }
                    }
                }
            }
        }

        // Triangular 3
        public void Triangular3()
        {
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = f1; c1 >= 1; c1--)
                {
                    for (int f2 = 1; f2 <= f; f2++)
                    {
                        for (int c2 = f2; c2 >= 1; c2--)
                        {
                            if (x[f1, c1] < x[f2, c2])
                            {
                                InterEle(f1, c1, f2, c2);
                            }

                        }
                    }
                }
            }
        }

        // Triangular 4
        public void Triangular4()
        {
            for (int c1 = 1; c1 <= c; c1++)
            {
                for (int f1 = c1; f1 <= f; f1++)
                {
                    for (int c2 = 1; c2 <= c; c2++)
                    {
                        for (int f2 = c2; f2 <= f; f2++)
                        {
                            if (x[f1, c1] < x[f2, c2])
                            {
                                InterEle(f1, c1, f2, c2);
                            }

                        }
                    }
                }
            }
        }

        // Triangular 5
        public void Triangular5()
        {
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = c - f1 + 1; c1 <= c; c1++)
                {
                    for (int f2 = 1; f2 <= f; f2++)
                    {
                        for (int c2 = c - f2 + 1; c2 <= c; c2++)
                        {
                            if (x[f1, c1] < x[f2, c2])
                            {
                                InterEle(f1, c1, f2, c2);
                            }

                        }
                    }
                }
            }
        }

        // Triangular 6
        public void Triangular6()
        {
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = c; c1 >= (c - f1 + 1); c1--)
                {
                    for (int f2 = 1; f2 <= f; f2++)
                    {
                        for (int c2 = c; c2 >= (c - f2 + 1); c2--)
                        {
                            if (x[f1, c1] < x[f2, c2])
                            {
                                InterEle(f1, c1, f2, c2);
                            }

                        }
                    }
                }
            }
        }

        // Triangular 7
        public void Triangular7()
        {
            for (int c1 = c; c1 >= 1; c1--)
            {
                for (int f1 = f - c1 + 1; f1 <= f; f1++)
                {
                    for (int c2 = c; c2 >= 1; c2--)
                    {
                        for (int f2 = f - c2 + 1; f2 <= f; f2++)
                        {
                            if (x[f1, c1] < x[f2, c2])
                            {
                                InterEle(f1, c1, f2, c2);
                            }

                        }
                    }
                }
            }
        }


        // 
        public void OrdDiago2()
        {

            for (int c1 = c; c1 >= 1; c1--)
            {
                for (int f1 = c1; f1 <= c1; f1++)

                {
                    for (int c2 = c; c2 >= 1; c2--)
                    {
                        for (int f2  =c2; f2 <= c2; f2++)

                        {
                            if (x[f1, c1] < x[f2, c2])
                            {
                                InterEle(f1, c1, f2, c2);
                            }

                        }
                    }


                }
            }

        }


    }
}
