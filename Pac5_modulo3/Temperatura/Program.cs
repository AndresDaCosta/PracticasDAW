using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] temperaturas = new String[5];
            Double media = new Double();

            Relleno(temperaturas);

            Calculo_media(temperaturas, ref media);

            Console.WriteLine("la media de las temperaturas de los paises es: " + media);

            Console.ReadLine();

        }

        static String[] Relleno(String[] array)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("introduce la Pais y la temperatura con el siguiente formato Pais,temperatura");

                array[i] = Console.ReadLine();

            }


            return array;
            
        }
        static void Calculo_media(String[] array, ref Double media)
        {

            int[] Nums_temps = new int[5];

            for(int i = 0; i < array.Length; i++)
            {

                String temperatura = array[i];

                int index_com = temperatura.IndexOf(',');

                String numero = temperatura.Substring(index_com + 1);

                Nums_temps[i] = int.Parse(numero);

                media = Nums_temps.Average();

            }


        }

    }
}
