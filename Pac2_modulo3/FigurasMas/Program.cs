using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasMas
{
    class Program
    {
        static void Main(string[] args)
        {

            //cadena vacia para añadirle caracteres
            String cadena = "";
            
            //Bucle ascendente con un indice maximo 5

            for(int i = 0; i <= 5; i++)
            {

                //añade un nuevo caracter.
                cadena = cadena.Insert(i, "*");

                Console.WriteLine(cadena);

            }

            //fin del programa 
            Console.ReadLine();


        }
    }
}
