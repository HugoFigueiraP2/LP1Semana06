using System;
using System.Data;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color minhaCor = Color.ShowColor(3,0,0,254);
            //Sphere vezes_lancadas = Sphere.Tw
            Sphere minhaEsfera = new Sphere(4,minhaCor);
            minhaEsfera.Throw();
            minhaEsfera.Throw();
            minhaEsfera.GetTimesThrown();
            
            Console.WriteLine(minhaCor);
            Console.WriteLine(minhaEsfera.GetTimesThrown());
        }
    }
}
