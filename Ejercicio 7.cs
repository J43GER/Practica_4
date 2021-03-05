using System;

namespace Visual_Studio_Code
{
    /* 7- Un programa que te pida tu nombre y 
    lo muestre en pantalla separando cada letra de la siguiente con un espacio. 
    Por ejemplo, si tu nombre es "Juan", debería aparecer en pantalla "J u a n". */
    class Program
    {
        static void Main(string[] args)
        {
            string espacio = " ";

            Console.WriteLine("Favor de introducir tu nombre.");
            string nombre = Console.ReadLine();

            foreach (char i in nombre)
            {
                Console.Write(i+espacio);
            }

        }
    }
}
