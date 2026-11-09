using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Practico_Emanuel_Vargas
{
    public class Rectangulo: Figura
    {

        public double B { get; set; }// base
        public double A { get; set; } // altura

        public Rectangulo(double b, double a)
        {
            B = b;
            A = a;
        }

        public override double CalcularArea()
        {
            return B * A;
        }

        public override double CalcularPerimetro()
        {
            return (B + A)*2;
        }
    }
}
