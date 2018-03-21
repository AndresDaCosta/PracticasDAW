using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioApesetas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            -progama que calcula una cantidad en pesetas ¿980908
            */

            Double Euros = new Double();
            Double Pesetas = new Double();
            Double Cambio = new Double();

            Console.WriteLine("Por favor introduce la cantidad para cambiar: ");

            Euros = Double.Parse(Console.ReadLine());

            if (Euros > 0)
            {
                Pesetas = 166.386;

                Cambio = Euros * Pesetas;

                Console.WriteLine("Usted tiene " + Cambio + "pesetas");

                Console.WriteLine("Presiona Cualquier Tecla para acabar ......");
                Console.ReadLine(); 
            }
            else
            {
                Console.WriteLine("el valor introducido no es valido, por favor asegurese que es mayor que 0");
            }

        }
    }
}
