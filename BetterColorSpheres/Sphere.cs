using System;
using System.Runtime.Intrinsics.X86;

namespace BetterColorSpheres
{
    public class Sphere
    {
        private int raio;
        private readonly Color cor;
        private int vezes_atirado;

        public Sphere ( int raio, Color cor)
        {
            this.raio = raio;
            this.cor = cor;
            this.vezes_atirado = 0;
        }

        public int Pop()
        {
            return raio = 0;

        }

        public int Throw()
        {
            if ( raio > 0)
            {
                vezes_atirado++;
                
            }
            return vezes_atirado;
        }

        public int GetTimesThrown()
        {
            return vezes_atirado;
        }




    }
}