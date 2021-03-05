using System;
using System.Linq;

namespace Visual_Studio_Code
{
    /* 8- Crear un programa que defina un array de 5 elementos de tipo float que representen las alturas de 5 personas.
        Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas. */
    class Program
    {
        public static void Main(string[] args)
        {
           double[] AlturasP = new double[5];
           int altas = 0, bajas = 0;

           for (int i = 0; i < AlturasP.Length; i++)
           {
               Console.WriteLine("Favor ingresar altura.");
               AlturasP[i] = double.Parse(Console.ReadLine());
           }

           double promedio = AlturasP.Sum() / 5;

           foreach (double i in AlturasP)
           {
               if (i < promedio)
               {
                   bajas++;
               }

               if (i > promedio)
               {
                   altas++;
               }
           }

           Console.Clear();

           Console.WriteLine("{0} Son mas altas que el promedio.", altas);
           Console.WriteLine("{0} Son mas bajas que el promedio.", bajas);
        

        }
    }
}
