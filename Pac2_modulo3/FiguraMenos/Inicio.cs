using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraMenos
{
    class Inicio
    {
        static void Main(string[] args)
        {

            String cadena = "******";

            for (int i = 5; i >= 1; i--)
            {

                //este metodo de string quita el caracter de valor i
                cadena = cadena.Remove(i);

                Console.WriteLine(cadena);

            }

            Console.ReadLine();


        }
    }
}
