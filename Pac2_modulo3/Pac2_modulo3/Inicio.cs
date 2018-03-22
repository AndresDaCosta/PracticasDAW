using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pac2_modulo3
{
    class Inicio
    {
        /*. Realiza un programa que pida un número entero y diga si es múltiplo de 2, de 3, de
            5, de 7, de 11 o de 13. Recuerda que hay números que pueden ser múltiplos de
            más de uno de los anteriores.
            
        @author: Jorge andre da costa ribeiro     
        */

        static void Main(string[] args)
        {

            //declaramos variables necesarias 
            int Numero_in = new int();
            int calculo = new int();
            int calculo2 = new int();
            Boolean confir = new Boolean();

            //pedimos el numero de entrada
            Console.WriteLine("Introduzca el Numero deseado");


            Numero_in = int.Parse(Console.ReadLine());
            
            //bucle que identifica los multiplos 
                        
            for (int i = 1;  i <= 13; i++)
            {
                calculo = Numero_in % i;   //calculo de un multiplo


                if (calculo == 0)
                {
                    switch (i)
                    {
                        //casos que iran contando si son multiplos de los numeros 

                        case 2:
                            Console.WriteLine("es multiplo de 2");
                            break;
                        case 3:
                            Console.WriteLine("es multiplo de 3");
                            break;
                        case 7:
                            Console.WriteLine("es multiplo de 7");
                            break;
                        case 11:
                            Console.WriteLine("es multipo de 11");
                            break;
                        case 13:
                            Console.WriteLine("es multipo de 13");
                            break;
                    }

                }
                else
                {
                    switch (i)
                    {

                        //añadimos otro Switch para mostrar en pantalla que no es multiplo de es numero
                        case 2:
                            Console.WriteLine("no es multiplo de 2");
                            break;
                        case 3:
                            Console.WriteLine("no es multiplo de 3");
                            break;
                        case 7:
                            Console.WriteLine("no es multiplo de 7");
                            break;
                        case 11:
                            Console.WriteLine("no es multipo de 11");
                            break;
                        case 13:
                            Console.WriteLine("no es multipo de 13");
                            break;

                    }



                }

                
            }

            Console.WriteLine("presiona cualquier tecla para acabar ");
            Console.ReadLine();
        }

    }
}