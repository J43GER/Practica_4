using System;
using System.Linq;

namespace Visual_Studio_Code
{
    class Practica_4
    {   
        static void Main(string[] args)
        {
          /*5- Un programa que prepare espacio para un máximo de 100 nombres. 
          El usuario deberá ir introduciendo un nombre cada vez, hasta que se pulse Intro sin teclear nada, 
          momento en el que dejarán de pedirse más nombres 
          y se mostrará en pantalla la lista de los nombres que se han introducido. */

          string[] nombres = new string[100];
          int c = -1;
          int c2 = 0;

         
            for (int i = 0; i <= 99; i++)
            {
                Console.Clear();
                Console.WriteLine("Favor de introducir un nombre.");
                nombres[i] = Console.ReadLine();

                c++;

                if (nombres[i] == "")
                {
                      break;
                }
                  
            }
                 foreach (string i in nombres)
                 {
                     Console.WriteLine(i);
                     c2++;

                     if (c2 == c)
                     {
                         break;
                     }
                 }
                
           



        }
    }
}
