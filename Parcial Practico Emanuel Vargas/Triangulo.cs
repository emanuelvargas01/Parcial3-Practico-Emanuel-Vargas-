using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Practico_Emanuel_Vargas
{
    public class Triangulo: Figura
    {
        public double B { get; set; } //la base
        public double A { get; set; }//la altura
        public double L1 { get; set; } // un lado del triangulo
        public double L2 { get; set; } // otro lado del triangulo

        public Triangulo(double bas, double altura,double lado1, double lado2)
        {
            B = bas;
            A = altura;
            L1 = lado1;
            L2 = lado2;
        }

        public override double CalcularArea()
        {
            return (B * A) / 2;
        }

        public override double CalcularPerimetro()
        {
            return B + L1 + L2;
        }
    }
}
