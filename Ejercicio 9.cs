using System;
using System.Linq;

namespace Visual_Studio_Code
{
    /* 9- Crear una clase que permita ingresar valores enteros por teclado 
    y nos muestre la tabla de multiplicar de dicho valor. 
    Finalizar el programa al ingresar el -1. */
    class Tabla
    {
        public static void Main(string[] args)
        {
            double num = 0;
            int num2 = 1;
            double[] tabla = new double[12];

            while (num != -1)
            {
                Console.WriteLine("Ingresar un numero para conocer su tabla de multiplicar. \n\nSi desea detener este proceso favor de introducir -1");
                num = double.Parse(Console.ReadLine()); 
                num2 = 1;

                for (int i = 0; i < tabla.Length; i++)
                {
                    tabla[i] = num * num2;

                    Console.WriteLine("{0} multiplicado por {1} es igual a: {2} ", num, num2, tabla[i]);

                    num2++;
                }   


            }

           
        }
    }
}
