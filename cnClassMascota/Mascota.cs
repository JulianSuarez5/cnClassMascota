using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Mascota
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string TipoAnimal { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        int cantidadMascotas;

        Console.Write("Ingrese la cantidad de mascotas: ");
        cantidadMascotas = Convert.ToInt32(Console.ReadLine());

        Mascota[] mascotas = new Mascota[cantidadMascotas];

        for (int i = 0; i < cantidadMascotas; i++)
        {
            Console.WriteLine("Ingrese la información de la mascota " + (i + 1));

            mascotas[i] = new Mascota();

            Console.Write("Nombre: ");
            mascotas[i].Nombre = Console.ReadLine();

            Console.Write("Edad: ");
            mascotas[i].Edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tipo de animal: ");
            mascotas[i].TipoAnimal = Console.ReadLine();
        }
        Console.WriteLine();

        Console.WriteLine("Datos de las mascotas que ingresaste:");

        foreach (var mascota in mascotas)
        {
            Console.WriteLine("Nombre: " + mascota.Nombre);
            Console.WriteLine("Edad: " + mascota.Edad + " Años");
            Console.WriteLine("Tipo de animal: " + mascota.TipoAnimal);
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
