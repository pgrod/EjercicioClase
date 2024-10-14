
namespace EjercicioClase
{
    public class Superheroe
    {
        public string Nombre { get; set; }
        public string identidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public bool puedeVolar { get; set; }
        public SuperPoder superPoder;

        public Superheroe()
        {
            superPoder = new SuperPoder();
        }

        public void imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {identidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede volar?: {puedeVolar}");
            Console.WriteLine($"Superpoder: {superPoder.nombre}");
            Console.WriteLine($"Descripción: {superPoder.descripcion}");
            Console.WriteLine($"Nivel: {superPoder.nivel}");
            Console.WriteLine();
        }
    }
}
