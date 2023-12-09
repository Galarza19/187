using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_Matrices
{
    class NEnt
    {
        //--------------------
        private int n;

        // CONSTRUCTOR----------------
        public NEnt()
        {
            n = 0;
        }

        // CARGAR---------------------------
        public void Cargar(int dato)
        {
            n = dato;
        }

        // VERIFICAR FIBONACCI------------------
        public bool VerifFibo()
        {
            bool b = true;
            int x, y, z;
            x = -1; y = 1;
            while (b)
            {
                z = x + y;
                if (z == n)
                {
                    b = true;
                    break;
                }
                else if (z > n)
                {
                    b = false;
                }
                x = y;
                y = z;
            }
            return b;
        }

        //VERIF PAR----------------
        public bool VerifPar()
        {
            return n % 2 == 0;
        }

        // VERIFICAR PRIMO----------------------
        public bool VerifPri()
        {
            int i, cont;
            cont = 0;
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }
            return (cont == 2);
        }

        // VERIFICAR SI CAPICUA
        public bool EsCapicua(int num)
        {
            int numreverso, numoriginal;
            numreverso = 0; numoriginal = num;
            while (num > 0)
            {
                int digito = num % 10;
                numreverso = (numreverso * 10) + digito;
                num = num / 10;
            }
            return (numoriginal == numreverso);
        }
    }
}
