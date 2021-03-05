using System;
using System.Linq;

namespace Visual_Studio_Code
{
    class Practica_4
    {   
        static void Main(string[] args)
        {
           /* 1- Un programa que pida al usuario 4 números, los memorice (utilizando un array), 
           calcule su media aritmética y después muestre en pantalla la media y los datos tecleados.*/

           double[] numeros = new double [4];

           for (int i = 0; i <= 3; i++)
           {
               Console.WriteLine("Favor introducir un número para sumar");
               numeros[i] = int.Parse(Console.ReadLine());
           }
            
            Console.Clear();
            
            double media = (numeros.Sum() / 4);

            Console.WriteLine("Los números insertados fueron: {0}, {1}, {2}, {3} \n\nY el resultado de su media aritmética es igual a: {4}", numeros[0], numeros[1], numeros[2], numeros[3], media );




            

        
        
           
        }
    }
}
