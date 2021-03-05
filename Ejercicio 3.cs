using System;
using System.Linq;

namespace Visual_Studio_Code
{
    class Practica_4
    {   
        static void Main(string[] args)
        {
           /* 3- Un programa que almacene en un array 
           el número de días que tiene cada mes (supondremos que es un año no bisiesto), 
           pida al usuario que le indique un mes (1=enero, 12=diciembre) 
           y muestre en pantalla el número de días que tiene ese mes. */

           Console.Clear();
           
           int[] Dias_mes = {28, 30, 31};
           int Mes = 0;

           Console.WriteLine("Ingresar mes (el número del mes), para mostrar cantidad de días");
           Mes = int.Parse(Console.ReadLine());

           if (Mes == 2)
           {
               Console.WriteLine(Dias_mes[0] + " Días.");
           }

           else if (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11 )
           {
               Console.WriteLine(Dias_mes[1] + " Días.");
           }

           else if (Mes == 1 || Mes == 3 || Mes == 5 || Mes == 7 || Mes == 8 || Mes == 10 || Mes == 12)
           {
               Console.WriteLine(Dias_mes[2] + " Días.");
           }

        }
    }
}
