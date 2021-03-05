using System;
using System.Linq;

namespace Visual_Studio_Code
{
    /* Confeccionar una clase que permita cargar el nombre y la edad de una persona. 
    Mostrar los datos cargados. 
    Imprimir un mensaje si es mayor de edad (edad>=18). */
    class NombreyEdad
    {
        struct Nombre_Edad
        {
            public string nombre;
            public int edad;
        }

        public static void Main(string[] args)
        {
            Nombre_Edad[] Personas = new Nombre_Edad[1];

            Console.WriteLine("Ingresar nombre de la persona.");
            Personas[0].nombre = Console.ReadLine();

            Console.WriteLine("Ingresar edad de la persona.");
            Personas[0].edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Se guardaron: \nNombre: {0}. \nEdad: {1}.", Personas[0].nombre, Personas[0].edad);

            if (Personas[0].edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }


           
        }
    }
}
