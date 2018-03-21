using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pac1_modulo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cifra1 = 3;
            Double cifra2 = 5.5;
            String texto1 = "hola mundo";

            //hello world
            Console.WriteLine("hello world");


            // se solicita  la edad al ususario con un mensaje
            Console.WriteLine("Por favor introduce tu edad:");


            String Edad = Console.ReadLine();  // salida de la consola es un String
            int Edad_num = int.Parse(Edad);   // se convierte el String de entrada de la consola en un tipo int

            // se solicita al usuario su altura con un decimal posible
            Console.WriteLine("por favor introduce tu altura con un decimal:");

            String Altura = Console.ReadLine();
            Double Altura_num = double.Parse(Altura);    // la entrada de la consola de tipo String se convierte en tipo Double

            //se solicita el nombre al usuario
            Console.WriteLine("Por favor introduce tu nombre:");

            String Nombre = Console.ReadLine();
        }
    }
}
