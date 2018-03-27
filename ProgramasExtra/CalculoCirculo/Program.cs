using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            
                /*
                  - programa que calcula el perimetro y el area de un circulo,
                    introduciendo el radio del mismo.
                */

                // se declaran la variables

                Double radio = new Double();
                Double Num_pi = new Double();
                Double Perimetro = new Double();
                Double Area = new Double();

                Console.WriteLine("Introduzca el radio: ");

                radio = Double.Parse(Console.ReadLine());

                if (radio <= 0)
                {
                    Console.WriteLine("El radio introducido no es correcto");

                }
                else
                {
                    Console.WriteLine("Se esta calculando el Perimetro de la circunferencia y El radio ......");

                    Num_pi = 3.1416;

                    Area = (Num_pi * radio * radio);
                    Perimetro = (2 * Num_pi * radio);

                    Console.WriteLine("El area de su circulo es " + Area + " y su perimetro es " + Perimetro);
                    Console.WriteLine("pulse cualquier tecla para acabar el programa .......");
                    Console.Read();


                }


            }
    }
}
