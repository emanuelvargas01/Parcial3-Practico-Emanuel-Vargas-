namespace Parcial_Practico_Emanuel_Vargas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Figura[] figuras = new Figura[3];
            figuras[0] = new Rectangulo(10, 5);
            figuras[1] = new Cuadrado(3);
            figuras[2] = new Triangulo(10, 4, 6, 8);
            foreach (Figura f in figuras)
            {
                Console.WriteLine("La Figura es: " + f.GetType().Name);
                Console.WriteLine("El Area de un " + f.GetType().Name+ " es: "+f.CalcularArea());
                Console.WriteLine("El Perimetro de un " + f.GetType().Name + " es: " + f.CalcularPerimetro());
  
             
            }
        }
    }
}








