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
            // creamos las variables que usaremos
            String[] temperaturas = new String[5];
            Double media = new Double();

            // llamamos a la funcion para rellenar el array d las tempretaturas
            Relleno(temperaturas);

            //llamamos a la funcion  para calcular la media de las temperaturas
            Calculo_media(temperaturas, ref media);

            Console.WriteLine("la media de las temperaturas de los paises es: " + media);

            Console.ReadLine();

        }

        static String[] Relleno(String[] array)
        {
            // hacemos un bucle para rellenar el array 
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("introduce la Pais y la temperatura con el siguiente formato Pais,temperatura");

                array[i] = Console.ReadLine();

            }

            // devolvemos el array relleno 
            return array;
            
        }
        // funcion para calcular la media
        static void Calculo_media(String[] array, ref Double media)
        {

            // creamos un array para guardar las temperaturas
            int[] Nums_temps = new int[5];

            //bucle para sacar las temperaturas del array donde estan guardadas
            for(int i = 0; i < array.Length; i++)
            {
                
                // sacamos el String de las temperaturas
                String temperatura = array[i];

                // buscamos la coma que separa el nombre del pais y la temperatura
                int index_com = temperatura.IndexOf(',');

                // sacamos el numero de la temperatura
                String numero = temperatura.Substring(index_com + 1);

                // la metemos en el array
                Nums_temps[i] = int.Parse(numero);

                

            }
            // sacamos la media de las temperaturas
            media = Nums_temps.Average();

        }

    }
}
