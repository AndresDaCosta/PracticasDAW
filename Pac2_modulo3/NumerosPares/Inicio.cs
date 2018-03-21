using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPares
{
    class Inicio
    {
        static void Main(string[] args)
        {
            /*Realiza un programa que pida dos números y muestre todos los números pares que
                haya entre ellos. Si el primer número es mayor que el segundo, debe invertir el
                    orden.
            */


            //declares variables
            int Numero_in1 = new int();
            int Numero_in2 = new int();
            int Devuelta = new int();
            Console.WriteLine("Por favor introduce el Primer numero");
            Numero_in1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor introduce el Segundo numero");
            Numero_in2 = int.Parse(Console.ReadLine());

            

            if(Numero_in1 > Numero_in2)
            {
                Devuelta = Numero_in1;
                Numero_in1 = Numero_in2;
                Numero_in2 = Devuelta;

                for(int i = Numero_in1; i < Numero_in2; i++)
                {
                    
                    if((i % 2) == 0)
                    {
                        Console.WriteLine(i);

                    }
                    else
                    {
                        
                    }


                }


            }
            else
            {

                for (int i = Numero_in1; i < Numero_in2; i++)
                {

                    if ((i % 2) == 0)
                    {
                        Console.WriteLine(i);

                    }
                    else
                    {
                        
                    }


                }


            }

            Console.ReadLine();

        }
    }
}
