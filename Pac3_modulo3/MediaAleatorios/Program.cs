using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Realiza un programa que tenga un array de 10 números aleatorios, y muestre su
                suma y la media de estos números.                */

            //Declaramos las variable que necesitamos.
            Random Numero = new Random(); //tipo random para numeros aleoatrios
            Double media = new Double(); // double por si la media da con decimales

            //Declaramos el array para contener los numeros aleatorios.
            int[] numeros = new int[10]; // de capacidad 10

            //bucle para asignar numeros aleatorios para el array de numeros
            for (int i = 0; i < numeros.Length ; i ++){

                //asigancion de la posicion del bucle un numero aleatorio
                numeros[i] = Numero.Next();

            }
            //bucle que recorre todo el array calcula la media hasta el momento una vez finalizado debera mostrar la media
            for (int x = 0; x < numeros.Length; x++)
            {

                //calculo de la media recorriendo el array con la variable x
                media = (media + numeros[x]) / numeros.Length;


            }

            //mostramos el resultado en pantalla
            Console.WriteLine("la media de los numeros que componen el array es: " + media);

            //paramos el programa para poder ver el resultado
            Console.Read();



        }
    }
}
