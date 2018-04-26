using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundirLaFlota
{
    class Program
    {
        static void Main(string[] args)
        {
            //hundir la flota
            // 
            //created by jorge andre da costa ribeiro.


            char[,] tablero = new char[11, 8];
            char[] letras = { 'A', 'B', 'C', 'D', 'F', 'G', 'H' };
            int count = 0;
            int corB = 0;
            /*barcos*/
            /*longitud 5*/
            char[] barcoP = { 'P', 'P', 'P', 'P', 'P' };
            /*longitud 4*/
            char[] barcoM = { 'M', 'M', 'M', 'M' };
            /*longitud 3*/
            char[] barcoT = { 'T', 'T', 'T'};
            /*longitud 2*/
            char[] barcoR = { 'R', 'R' };
            char[] barcoSE = { };
            /*opciones*/
            Boolean vertical = new Boolean();
            Boolean horizontal = new Boolean();
            Boolean arriba = new Boolean();
            Boolean derecha = new Boolean();

            /*Output de la primera impresion */
          
            for ( int i = 0; i <= 7; i++)
            {
                
                Console.WriteLine("+---++---++---++---++---++---++---++---++---++---++----+");
                for (int x = 0; x <= 10; x++)
                {
                    
                    if ( i == 0)
                    {
                                                
                        tablero[x, i] = Convert.ToChar(x);
                        Console.Write("| " + Convert.ToInt16(tablero[x,i]) + " |");
                    }
                    else
                    {
                        if (x == 0 & i > 0)
                        {
                            tablero[x, i] = letras[count];
                            Console.Write("| " + tablero[x,i] + " |");
                            count++;
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

            /*las marcas del tablero estan rellenas*/
            Console.WriteLine("Jugador 1 (ATACADO) por favor pulsa ENTER para continuar");
            Console.ReadLine();
            Console.Clear();
            
            /*procedemos a marcar los barcos*/
            
            Console.WriteLine("barcos disponibles");
            Console.WriteLine("1- Barco P longitud " + barcoP.Length);
            Console.WriteLine("2- Barco M longitud " + barcoM.Length);
            Console.WriteLine("3- Barco T longitud " + barcoT.Length);
            Console.WriteLine("4- Barco R longitud " + barcoR.Length);

            Console.WriteLine("Elije el barco que quieres con el numero del menu.");
            for(int i = 1; i <= 4; i++) { 
                switch (int.Parse(Console.ReadLine()))
                {

                    case 1:
                        Console.WriteLine("has elejido el barco P con longitud " + barcoP.Length);
                        barcoSE = barcoP;
                        break;
                    case 2:
                        Console.WriteLine("has elejido el barco M con longitud " + barcoM.Length);
                        barcoSE = barcoP;
                        break;
                    case 3:
                        Console.WriteLine("has elejido el barco T con longitud " + barcoT.Length);
                        barcoSE = barcoT;
                        break;
                    case 4:
                        Console.WriteLine("has elejido el barco R con longitud " + barcoR.Length);
                        barcoSE = barcoR;
                        break;

                }
                
                Console.WriteLine("Como lo quieres poner Vertical o Horizontal ?");
                String option = Console.ReadLine();

                if(option == "vertical")
                {
                    vertical = true;
                }
                else
                {
                    vertical = false;
                }

                Console.WriteLine("inserta las cordenada inicial del barco !LETRA EN MAYUSCULA!");

                String cordenada = Console.ReadLine();
                char[] cordenadaCh = cordenada.ToArray();

                

                if (vertical == true & horizontal == false)
                {

                    if (cordenadaCh.Length == 3)
                    {
                        corB = 10;
                    }
                    else{

                        corB = int.Parse(cordenada.Substring(1));
                        
                    }

                    Console.WriteLine("Quieres que se ponga hacia arriba o hacia abajo");
                    
                    if(Console.ReadLine() == "arriba")
                    {

                        for(int t = 0; t < 8; t++)
                        {
                            
                            if(cordenadaCh[0].Equals(letras[t]))
                            {

                                if (((t+1) - barcoSE.Length) >= 0)
                                {
                                    tablero[corB, (t + 2)] = barcoSE[0];

                                    for(int u = 1; u <= (barcoSE.Length - 1); u++)
                                    {
                                        int p = (t+2) - u;

                                        tablero[corB, p] = barcoSE[u];
                                        
                                    }
                                    

                                }
                                else
                                {

                                }

                            }
                            else
                            {

                            }

                        }

                    }
                    else
                    {

                    }

                }
                else
                {
                    Console.WriteLine("Quieres que se ponga hacia la derecha o hacia abajo");

                    if (Console.ReadLine() == "derecha")
                    {

                    }
                    else
                    {

                    }
                }
               
                

            }

        }
    }
}
