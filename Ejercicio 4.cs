using System;
using System.Linq;

namespace Visual_Studio_Code
{
    class Practica_4
    {   
        static void Main(string[] args)
        {
           /*4- Un programa que pida al usuario 10 números y luego calcule 
           y muestre cuál es el mayor de todos ellos. */

           Console.Clear();

           double[] conjunto = new double[10];

           for (int i = 0; i <= 9; i++)
           {
               Console.WriteLine("Favor introducir un número (pueden ser decimales).");
               conjunto[i] = double.Parse(Console.ReadLine());
           }

           Console.WriteLine("El mayor de los números ingresados es: {0}", conjunto.Max());



        }
    }
}
