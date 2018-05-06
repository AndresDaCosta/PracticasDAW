using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pac5_modulo3
{
    class Inicio
    {
        static void Main(string[] args)
        {

            /*Crea un programa con un array de 100 números enteros aleatorios.
                - Crea una función que busque el número mayor con la siguiente cabecera:
                    static int mayor (int[] array)
                - Crea una función que busque el número menor con la siguiente cabecera:
                    static void menor (int[] array, ref int menor)
                - Crea una función que calcule la media:
                    static void calcular_media (int[] array, out double media)*/

            // creamos el array de los numeros aleatorios
            int[] Aleatorios = new int [100];
            int menor = new int();
            double media = new double();
            Random num_random = new Random();
            // rellenamos el array de los numeros
            for (int i = 0; i < 100; i++)
            {
                               
                // rellenamos el array con el siguiente numero aleatorio
                Aleatorios[i] = num_random.Next();

            }

            //buscamo el numero mayor y lo sacamos por pantalla llamando al metodo Mayor

            Console.WriteLine(Mayor(Aleatorios));

            // buscamos el menor
            Menor(Aleatorios, ref menor);

            // buscamos la media llamando al metodo Calcular_media
            Calcular_media(Aleatorios, out media);

            // sacamos por pantalla la madia
            Console.WriteLine(media);

            // paramos la consola a para ver el serultado
            Console.ReadLine();

        }
        // metodo Mayor, recibe un array de int y saca un Int que el el valor maximo del array
        static int Mayor(int[] array)
        {
            // calculamos el valor maximo del array
            int Num_mayor = array.Max();

            // devolvemos ese numero
            return Num_mayor;
        }
        // funcion Menor recibe un array de tipo de int y por referencia un int previamente declarado.
        static void Menor(int[] array, ref int menor)
        {
            // igualamos la ref de menor al valor minimo de del array 
            menor = array.Min();

            // imprimimos el la variable menor por pantalla
            Console.WriteLine(menor);
            
        }
        //Funcion de calcular la media recibe un array de tipo de int y saca en out la variable media de tipo Double    
        static void Calcular_media(int[] array, out double media)
        {

            // igualamos la media a la media del array
            media = array.Average();


        }
    }
}
