﻿using System;
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
                

            }
            for (int i = 0; i < 10; i++)
            {

                for (int x = 0; x < 10; x ++)
                {
                     
                   for(int y = 1; y <= 100; y ++)
                    {

                        if((matriz[i,x]%y) == 0)
                        {
                            
                            contador++;
                        }

                        
                    }



                   if(contador > 2)
                    {

                        matriz[i, x] = 'x';

                    }

                    contador = 0;

                }


            }

            

            for(int i = 0; i < 10; i++)
            {

                for(int x = 0; x < 10; x++)
                {

                    if(matriz[i,x] == 120)
                    {

                        Console.Write(" x ");

                    }
                    else
                    {

                        Console.Write(" " + matriz[i, x] + " ");

                    }

                    

                }



                Console.WriteLine();
            }


            Console.ReadLine();


        }
    }
}
