using System;
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
    }
}

