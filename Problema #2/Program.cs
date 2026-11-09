using Newtonsoft.Json;
namespace Problema__2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var persona = new { Nombre = "Emanuel", Edad = 20, Carrera = "Ingenieria en Sistemas" };
            string json = JsonConvert.SerializeObject(persona);
            Console.WriteLine(json);
        }
    }
}
