using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            - programa que calcula la media de tres numero que introduce el ususario
            */

            //declares variables 
            int Num_1 = new int();
            int Num_2 = new int();
            int NUm_3 = new int();
            Double Media = new Double();


            // user IN de DATA 
            Console.WriteLine("Introduce el Primer valor: ");
            Num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el Segundo valor: ");
            Num_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo valor:");
            NUm_3 = int.Parse(Console.ReadLine());

            
            Console.WriteLine("se esta calculado la media de los tres numero: ");

            //calcule the result
            Media = (Num_1 + Num_2 + NUm_3) / 3;

            Console.WriteLine("CONSEGUIDO LO TENEMOS ");

            //program Out
            Console.WriteLine("La media de los numeros es: " + Media);

            Console.WriteLine("pulsa cualquier tecla para acabar.......");
            Console.ReadLine();


            




        }
    }
}
