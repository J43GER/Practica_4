using System;
using System.Linq;

namespace Visual_Studio_Code
{
    class Practica_4
    {   
        static void Main(string[] args)
        {
           /* 2) Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float") 
           y luego los muestre en el orden contrario al que se introdujeron. */

           float[] numerosR = new float [5];

           for (int i = 0; i <= 4; i++)
           {
               Console.WriteLine("Favor introducir un número real (con decimales).");
               numerosR[i] = float.Parse(Console.ReadLine());
           }

           Console.Clear();

            Array.Reverse(numerosR);

            Console.WriteLine("Los números invertidos en orden de ingreso:");
            foreach (double i in numerosR)
            {
                Console.WriteLine(i);
            }

        }
    }
}
