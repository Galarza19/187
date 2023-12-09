﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_Matrices
{
    class VECTORES
    {
        const int MAX = 50;
        private int[] v;
        private int n;
        //-------------------------
        public VECTORES()
        {
            n = 0;
            v = new int[MAX];
        }

        // Cargar random---------------------------
        public void Cargar(int n1, int a, int b)
        {
            Random r = new Random();
            n = n1;
            for (int i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }

        // Cargar Vector vacío------------
        public void Cargar(int ele)
        {
            n++;
            v[n] = ele;
        }

        // Descargar-------------------------
        public string Descargar()
        {
            string s = "";
            for (int i = 1; i <= n; i++)
            {
                s = s + v[i] + " | ";
            }
            return s;
        }

        // Frecuencia-----------------------
        public int Frec(int ele)
        {
            int frec = 0;
            for (int i = 1; i <= n; i++)
            {
                if (ele == v[i])
                {
                    frec++;
                }
            }
            return frec;
        }

        // Se encuentra?-------------------------------
        public bool SeEncuentra(int nbus)
        {
            int i = 1;
            bool bandera = false;
            while ((i <= n) && (bandera == false))
            {
                if (v[i] == nbus)
                {
                    bandera = true;
                }
                i++;
            }
            return bandera;
        }

        // Intercambiar---------------------------------
        public void Intercambiar(int p1, int p2)
        {
            int aux;
            aux = v[p1];
            v[p1] = v[p2];
            v[p2] = aux;
        }

        // Elemento de mayor frec------------------------
        public void OrdEleMayFrec(VECTORES e, VECTORES f)
        {
            for (int i = 1; i <= n; i++)
            {
                if (!e.SeEncuentra(v[i]))
                {
                    e.Cargar(v[i]);
                    f.Cargar(Frec(v[i]));
                }
            }
            for (int p = 1; p < f.n; p++)
            {
                for (int d = p + 1; d <= f.n; d++)
                {
                    if (f.v[d] > f.v[p])
                    {
                        f.Intercambiar(d, p);
                        e.Intercambiar(d, p);
                    }
                }
            }
            int ii = 0;
            for (int j = 1; j <= e.n; j++)
            {
                for (int k = 1; k <= f.v[j]; k++)
                {
                    ii++;
                    v[ii] = e.v[j];
                }
            }
        }

        // Retornar elemento-------------
        public int RetEle(int p)
        {
            return v[p];
        }

        //--------------------------
        public void ElimReps()
        {
            int aux = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (v[i] == v[j])
                    {
                        v[j] = 0;
                    }
                }
            }
            for (int i = 1; i <= n; i++)
            {
                if (v[i] != 0)
                {
                    aux++;
                    v[aux] = v[i];
                }
            }
            n = aux;
        }
        public void EleUnicos()
        {
            int j = 0;
            for (int i = 1; i <= n; i++)
            {
                if (Frec(i) == 1)
                {
                    j++;
                    v[j] = i;
                }
            }
            n = j;
        }
        public int EleNoRepV()
        {
            return n;
        }
      
        public void VOrdDiagSec()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (v[j] > v[i])
                    {
                        Intercambiar(j, i);
                    }
                }
            }
        }

        public void VOrdTri()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (v[j] < v[i])
                    {
                        Intercambiar(j, i);
                    }
                }
            }
        }







    }
}
