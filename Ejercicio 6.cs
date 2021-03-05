using System;
using System.Linq;

namespace Visual_Studio_Code
{
/* 6- Un programa que permita guardar datos de "imágenes" 
    (ficheros de ordenador que contengan fotografías o cualquier otro tipo de información gráfica). 
    De cada imagen se debe guardar: nombre (texto), 
    ancho en píxeles (por ejemplo 2000), 
    alto en píxeles (por ejemplo, 3000), 
    tamaño en Kb (por ejemplo 145,6). 
    El programa debe ser capaz de almacenar hasta 700 imágenes 
    (deberá avisar cuando su capacidad esté llena). Debe permitir las opciones: 
    añadir una ficha nueva, ver todas las fichas (número y nombre de cada imagen), 
    buscar la ficha que tenga un cierto nombre. */ 

    public class Imagenes
    {
        struct datosimagenes
        {
            public string nombre;
            public int ancho;
            public int alto;
            public double tamaño;
        }
        
        public static void Main()
        {
           datosimagenes[] imagenes = new datosimagenes[700];
           int x = 0;
           int z = 1;
           string nombre;

          do
          {
            z = 1;
            Console.Clear();
            Console.WriteLine("Que desea hacer?");
            Console.WriteLine("1- Añadir nueva ficha\n2- Ver todas las fichas\n3- Buscar una ficha. (Por nombre).\n0- Salir.");
            x = int.Parse(Console.ReadLine());
              
              switch (x)
           {
             case 1:
              
              for (int i = 0; i <= 699; i++)
              {
                Console.WriteLine("Ingresar nombre de la imagen");
                imagenes[i].nombre = Console.ReadLine();

                Console.WriteLine("Ingresar ancho de la imagen");
                imagenes[i].ancho = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresar alto de la imagen");
                imagenes[i].alto = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresar tamaño de la imagen");
                imagenes[i].tamaño = double.Parse(Console.ReadLine());

                Console.WriteLine("Desea añadir otra imagen? \nIngrese cualquier numero para continuar. \nIngrese 0 para salir");
                int y = int.Parse(Console.ReadLine());

                if (y == 0)
                {
                    break;
                }

              }
              break;
              
              case 2:

              foreach (datosimagenes i in imagenes)
                 {
                     Console.WriteLine("Imagen {0}; nombre: {1}, ancho: {2}, alto: {3}, tamaño: {4} ", z, i.nombre, i.ancho, i.alto, i.tamaño);
                     z++;
                 }
                    break;

                    case 3:

                    Console.WriteLine("Favor de introducir nombre de imagen deseada.");
                    nombre = Console.ReadLine();

                    foreach (datosimagenes i in imagenes)
                    {
                       if (nombre == i.nombre)
                       {
                           Console.WriteLine("Nombre: {0} Ancho: {1} alto: {2} tamaño: {3}", i.nombre, i.ancho, i.alto, i.tamaño);
                       }

                    }

                    break;
               
           }

              
          } while (x != 0);

           


        }
    } 


}
