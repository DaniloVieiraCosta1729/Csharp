using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ReforcandoConceitos
{
    public class Delegates
    {
        public int Maior(int a, int b)
        {
            int resultado = (a > b) ? a : b;

            return resultado;
        }

        public float Maior(float a, float b)
        {
            float resultado = (a > b) ? a : b;

            return resultado;
        }
    }
}
