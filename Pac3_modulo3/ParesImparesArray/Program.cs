using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativosPositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realiza un programa que tenga un array de 100 números aleatorios, entre los
                valores -100 y 100, y mediante una criba, cree dos arrays. Uno de ellos tendrá
                    únicamente los números positivo, y el otro, los números negativos. */

            //declaramos las variable necesarias
            Random Numero = new Random();  //Tipo random para los numeros aleatorios
            int[] Numeros = new int[100]; // array capacidad 100 para los numeros
            int[] Positivos = new int[100]; // array para los positivos capacidad 100
            int[] negativos = new int[100]; // array capacidad 100 para negativos

            //creamos contadores para ordenar el array
            int contadorPosi = new int();
            int contadorNega = new int();

            //bucle para asignar el numero aleatorio al una posicion del Array
            for (int i = 0; i < Numeros.Length; i++)
            {

                //asigancion de la posicion del bucle un numero aleatorio entre -100 y 100
                Numeros[i] = Numero.Next(-100 ,100);

            }
            //inspeccionamos el array de los numeros aleatorios.
            for(int x = 0; x < 100; x++)
            {
                //positivo
                if(Numeros[x] > 0)
                {
                    //igualamos el numero en el array de positivos
                    Positivos[contadorPosi] = Numeros[x];//indizamos el array con un contador para porder ordenarlos
                    contadorPosi ++; // cada paso lo aumentamos
                }
                //negativo
                else
                {
                    //igualamos el numero en el array de negativos
                    negativos[contadorNega] = Numeros[x]; //indizamos el array con un contador para porder ordenarlos
                    contadorNega ++;// cada paso lo aumentamos
                }

            }

            Console.WriteLine("Resultados del Programa.");

            Console.WriteLine("En el array de 100 numeros habia " + contadorPosi + " numeros positivos y " + contadorNega + " negativos");
            Console.ReadLine();

        }
    }
}
