using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimension
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Realiza un programa que tenga una matriz (array bidimensional) con los 100 primeros números. 
             * Mostrará esta matriz marcando con una X los números que no son primos, de forma que, únicamente 
             * se vean los números primos. */

            //creamos la matriz para los numeros
            int[,] matriz = new int[10, 10];
            int contador = new int(); //creamos un contador para un uso posterior

            for (int i = 0; i < 10; i++)
            {   
                //rellenado del lado X de la matriz
                for(int x = 0; x < 10; x++)
                {
                    //formula para el rellenado de la matriz
                    matriz[i, x] = (i*10) + x;

                }
                
                //se devuelve la matriz rellenada
            }


            // bucle de calculo de numeros primos
            for (int i = 0; i < 10; i++)
            {
                //bucle para recorrer la matriz 
                for (int x = 0; x < 10; x ++)
                {
                     
                   for(int y = 1; y <= 100; y ++)
                    {
                        //calculador de numeros primos si la division no es decimal suma contador
                        if((matriz[i,x]%y) == 0)
                        {
                            //contador simple que previamente se creo para esta funcion
                            contador++;
                        }

                        
                    }


                   // control de numeros primos si contador es mayor que dos que se interpretaria como que ese numero
                   // es dvisible por mas numero que si mismo y 1 pues se dicta que no es primo por tanto se marca con 
                   // un char x
                   if(contador > 2)
                    {
                        //se sustitulle por char x el numero inspeccionado 
                        matriz[i, x] = 'x';

                    }

                   //se resetea el contador cada vez que acaba todo el proceso
                    contador = 0;

                }


            }

            
            //bucle para mostrar la matriz 
            for(int i = 0; i < 10; i++)
            {

                for(int x = 0; x < 10; x++)
                {
                    //dado que el char en el matriz se ha representado en un numero se crea un if para representarlo.
                    if(matriz[i,x] == 120)
                    {

                        Console.Write(" x ");

                    }
                    else
                    {
                        //si no es el numero 120 se muestra el numero que ocupa.
                        Console.Write(" " + matriz[i, x] + " ");

                    }

                    

                }



                Console.WriteLine();
            }


            Console.ReadLine();


        }
    }
}
