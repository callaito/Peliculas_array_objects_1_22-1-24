using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_object_01_22_1_2024
{
    internal class Peliculas
    {
        public string Nombre { get; set; }

        public string Genero { get; set; }

        public double Duracion { get; set; }

        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre:  {Nombre}");
            Console.WriteLine($"Género:  {Genero}");
            Console.WriteLine($"Duración:  {Duracion}");
        }
    }
}
