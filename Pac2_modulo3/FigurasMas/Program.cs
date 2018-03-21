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

            String cadena = "";
                    
            for(int i = 0; i <= 5; i++)
            {

                cadena = cadena.Insert(i, "*");

                Console.WriteLine(cadena);

            }

            Console.ReadLine();


        }
    }
}
