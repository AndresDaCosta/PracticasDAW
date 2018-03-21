using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Realiza un programa que escriba las tablas de multiplicar del 1 al 10*/

            //bucle automatico para las tablas 
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("******Tabla de multiplicar del " + i + " ************");
                Console.WriteLine("1 x " + i + " = " + 1 * i);
                Console.WriteLine("2 x " + i + " = " + 2 * i);
                Console.WriteLine("3 x " + i + " = " + 3 * i);
                Console.WriteLine("4 x " + i + " = " + 4 * i);
                Console.WriteLine("5 x " + i + " = " + 5 * i);                
                Console.WriteLine("6 x " + i + " = " + 6 * i);                
                Console.WriteLine("7 x " + i + " = " + 7 * i);                
                Console.WriteLine("8 x " + i + " = " + 8 * i);                
                Console.WriteLine("9 x " + i + " = " + 9 * i);                
                Console.WriteLine("10 x " + i + " = " + 10 * i);

            }

            Console.ReadLine();

        }
    }
}
