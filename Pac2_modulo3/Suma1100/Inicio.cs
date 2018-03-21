using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma1100
{
    class Inicio
    {
        static void Main(string[] args)
        {

            /*Realiza un programa que pida dos números y muestre todos los números pares que
                haya entre ellos. Si el primer número es mayor que el segundo, debe invertir el
                    orden.*/

            int cuenta = new int();
            int posicion = new int();
            int numeros = new int();
            
            for(int i = 1; i <= 100; i++)
            {

                if ((i % 2) != 0)
                {

                    posicion = cuenta;
                    cuenta = posicion + i;

                    Console.WriteLine(cuenta);

                    numeros ++;

                }
            }

            Console.WriteLine("entre el numero 1 y el 100 hay " + numeros + " numeros impares");

            Console.ReadLine();
        }
    }
}
