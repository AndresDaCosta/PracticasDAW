﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Creacion del juego del buscaminas en C# para el terminal 

            @author: jorge andre da costa ribeiro
            @date: 10/05/2018

            */

            char[,] Tableros = new char[11, 11];


            
            Tablero(Tableros);
            Minado(ref Tableros);
            Console.Clear();
            Tablero(Tableros);
            Boolean mina = jugar(out string cordenada, ref Tableros);
            Console.ReadLine();


        }
        static void Tablero(char[,] Tablero)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("+---++---++---++---++---++---++---++---++---++---++----+");
                
                for (int x = 0; x <= 10; x++)
                {


                    if (i == 0)
                    {

                        Tablero[x, i] = Convert.ToChar(x);
                        Console.Write("| " + Convert.ToInt16(Tablero[x, i]) + " |");
                    }
                    else
                    {
                        if (x == 0 & i > 0)
                        {

                            Tablero[x, i] = Convert.ToChar(i);
                            Console.Write("| " + Convert.ToInt16(Tablero[x, i]) + " |");
                        }
                        else
                        {


                            Console.Write("| " + " " + " |");

                        }
                    }




                }
                Console.WriteLine();


            }
            Console.WriteLine("+---++---++---++---++---++---++---++---++---++---++----+");

        }
        static void Minado( ref char[,] Tablero)
        {
            //Funcion que rellena las minas en el tablero.
            // numero aleatorios para posicionar las minas
            Random aleatorio = new Random();
            int NumeroX = new int();
            int NumeroY = new int();

            //ponemos 10 minas
            for(int m = 0; m <= 10; m++)
            {
                //coordenadas para posicionar las minas aleatoriamente
                NumeroX = aleatorio.Next(0, 10);
                NumeroY = aleatorio.Next(0, 10);

                Tablero[(NumeroX + 1), (NumeroY + 1)] = '*';

            }
               
                   


        }

        // funcion para 
        static Boolean jugar(out string cordenada, ref char[,] tablero)
        {
            Console.WriteLine("seleccione una coordenada para destapar");
            cordenada = Console.ReadLine();

            int index_com = cordenada.IndexOf(',');

            int numero = int.Parse(cordenada.Substring(0, index_com));
            int numero2 = int.Parse(cordenada.Substring(index_com + 1));
            Boolean mina = false;

            if (tablero[(numero + 1), (numero2 + 1)] == '*')
            {

                mina = true;

                Console.WriteLine("se ha encontardo una mina");

            }


            


            return mina;
        }

        // funcion para escanear el tablero
        static void Scanner()
        {



        }


    }
}

