// See https://aka.ms/new-console-template for more information
using array_object_01_22_1_2024;

Console.WriteLine("GESTION DE PELICULAS Y SERIES");
Console.WriteLine();

Peliculas[] peli = new Peliculas[3];

for (int i = 0; i < peli.Length; i++)
{
    

    peli[i] = new Peliculas();
    Console.WriteLine("DATOS DE LA PELICULA O SERIE No. " + (i + 1));

    Console.WriteLine("Nombre: ");
    peli[i].Nombre = Console.ReadLine();

    Console.WriteLine("Gérero: ");
    peli[i].Genero = Console.ReadLine();

    Console.WriteLine("Duración: ");
    peli[i].Duracion=double.Parse(Console.ReadLine());

    Console.WriteLine();
}

//Impirmir los datos

for (int i = 0; i < peli.Length; i++)
{
    Console.WriteLine("DATOS DE LA PELICULA O SERIE No. " + (i + 1));
    Console.WriteLine();
    Console.WriteLine("========================================");
    peli[i].ImprimirDatos();
    Console.WriteLine();
    Console.WriteLine("========================================");

}
