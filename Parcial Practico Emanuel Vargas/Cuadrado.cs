using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Practico_Emanuel_Vargas
{
    public class Cuadrado:Figura
    {
        public double L { get; set; } // L es el lado del cuadrado

        public Cuadrado(double l)
        {
            L = l;
        }

        public override double CalcularArea()
        {
            return L * L;
        }

        public override double CalcularPerimetro()
        {
            return L*4;
        }
    }
}
