using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realiza un programa que calcule la media de X números. Se dejarán de solicitar
                números cuando se introduzca el 0.*/

            int Numero_in = new int();
            int Media = new int();
            int Contador = new int();
            int Datos = new int();

            do
            {
                Datos = Media;

                Contador++;

                Console.WriteLine("Escriba un numero para la media");
                Numero_in = int.Parse(Console.ReadLine());

                Media = (Datos + Numero_in)/ Contador;

                Console.WriteLine("La media es" + Media);               

            } while (Numero_in != 0);

            Console.WriteLine("Has introducido el numero 0, SE ACABO, pulsa cualquier tecla para acabar ....");
            Console.ReadLine();

        }
    }
}
