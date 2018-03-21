using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivoNegativo
{
    class Inicio
    {
        static void Main(string[] args)
        {
            /*Realiza un programa que pida un número real hasta que el usuario introduzca el
                número 0. Si el número es mayor que 0, sacará por pantalla “POSITIVO”. Si el
                número es menor que 0, sacará por pantalla “NEGATIVO”.*/

            int Numero_in = new int();

            do
            {
                

                Console.WriteLine("Introduce un numero real incluido el cero:   ");

                Numero_in = int.Parse(Console.ReadLine());

                if(Numero_in > 0)
                {
                    Console.WriteLine("el numero " + Numero_in + " es positivo ");
                }
                else
                {
                    Console.WriteLine("el numero " + Numero_in + " es negativo ");
                }


            } while (Numero_in != 0);

            Console.WriteLine("Has escrito el 0 por lo tanto se da por finalizado el programa, pulsa para acabar..");
            Console.ReadLine();



            

        }
    }
}
