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
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            int count = 0;
            int corB = 0;
            int corBa = 0;
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
            Boolean barco2 = false;
            Boolean barco3 = false;
            Boolean barco4 = false;
            Boolean barco5 = false;
            int contador = 0;
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
            
           

            
            for(int i = 1; i <= 4; i++) {

                Console.Clear();

                Console.WriteLine("barcos disponibles");
                Console.WriteLine("1- Barco P longitud " + barcoP.Length);
                Console.WriteLine("2- Barco M longitud " + barcoM.Length);
                Console.WriteLine("3- Barco T longitud " + barcoT.Length);
                Console.WriteLine("4- Barco R longitud " + barcoR.Length);
                Console.WriteLine("Elije el barco que quieres con el numero del menu.");

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

                if (cordenadaCh.Length == 3)
                {
                    corB = 10;
                }
                else
                {

                    corB = int.Parse(cordenada.Substring(1));

                }



                if (vertical == true & horizontal == false)
                {



                    Console.WriteLine("Quieres que se ponga hacia arriba o hacia abajo");

                    if (Console.ReadLine() == "arriba")
                    {

                        for (int t = 0; t < 7; t++)
                        {

                            if (cordenadaCh[0].Equals(letras[t]))
                            {

                                if (((t + 1) - barcoSE.Length) >= 0)
                                {
                                    tablero[corB, (t + 1)] = barcoSE[0];

                                    for (int u = 1; u <= (barcoSE.Length - 1); u++)
                                    {
                                        int p = (t + 1) - u;

                                        tablero[corB, p] = barcoSE[u];

                                    }

                                    t = 8;
                                }
                                else
                                {

                                    Console.WriteLine("El barco no cabe por favor cambia tus parametros");

                                    t = 8;
                                }

                            }
                            else
                            {






                            }

                        }

                    }
                    else
                    {

                        for (int y = 0; y < 8; y++)
                        {
                            if (cordenadaCh[0].Equals(letras[y]))
                            {

                                if (((y + 1) + barcoSE.Length) <= 8)
                                {

                                    tablero[corB, (y + 1)] = barcoSE[0];

                                    for (int u = 1; u <= (barcoSE.Length - 1); u++)
                                    {
                                        int p = (y + 1) + u;

                                        tablero[corB, p] = barcoSE[u];

                                    }

                                    y = 9;
                                }


                            }
                            else
                            {


                            }




                        }





                    }

                }
                else
                {
                    Console.WriteLine("Quieres que se ponga hacia la derecha o hacia la izquierda");

                    if (Console.ReadLine() == "derecha")
                    {

                        for (int m = 0; m < 8; m++)
                        {
                            if (cordenadaCh[0].Equals(letras[m]))
                            {

                                if (((corB - 1) + barcoSE.Length) <= 10)
                                {

                                    tablero[corB, (m + 1)] = barcoSE[0];

                                    for (int o = 1; o <= (barcoSE.Length - 1); o++)
                                    {
                                        int ñ = (corB) + o;

                                        tablero[ñ, (m + 1)] = barcoSE[o];

                                    }

                                    m = 9;
                                }





                            }
                            else
                            {


                            }




                        }
                    }
                    else
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            if (cordenadaCh[0].Equals(letras[l]))
                            {

                                if (((corB ) - barcoSE.Length) >= 0)
                                {

                                    tablero[corB, (l + 1)] = barcoSE[0];

                                    for (int v = 1; v <= (barcoSE.Length - 1); v++)
                                    {
                                        int ñ = (corB) - v;

                                        tablero[ñ, (l + 1)] = barcoSE[v];

                                    }

                                    l = 9;
                                }





                            }
                            else
                            {


                            }






                        }
                    }
                }
               
                

            }

            Console.WriteLine("Muy bien Jugador 1, has colocado todos los barcos. AHORA ES EL TURNO DEL ATACANTE. pulsa cualquier tecla para que empiece el juego");
            Console.ReadLine();
            Console.Clear();

            


            do
            {

                Console.WriteLine("Indica la cordenada para disparar");

                String CordenadaAt = Console.ReadLine();
                char[] CordenadaCh = CordenadaAt.ToCharArray();

                if (CordenadaCh.Length == 3)
                {
                   corBa = 10;
                }
                else
                {

                    corBa = int.Parse(CordenadaAt.Substring(1));

                }




                for (int d = 0; d < 7; d++)
                {
                    


                    if (CordenadaCh[0].Equals(letras[d]))
                    {
                       
                        int eje = d + 1;

                        if (tablero[corBa, eje] != '\0')
                        {

                            switch(tablero[corBa, eje])
                            {

                                case 'P':

                                     
                                    char charToremove = 'P';
                                    int numIdx = Array.IndexOf(barcoP, charToremove);
                                    List<char> tmp = new List<char>(barcoP);
                                    tmp.RemoveAt(numIdx);
                                    barcoP = tmp.ToArray();
                                    
                                    if(barcoP.Length == 0)
                                    {

                                        barco5 = true;

                                        Console.WriteLine("Tocado y hundido el barco P con 5 unidades");

                                    }
                                    else
                                    {
                                        Console.WriteLine("barco Tocado");

                                    }
                                    d = 8;

                                    break;

                                case 'M':

                                    charToremove = 'M';
                                    numIdx = Array.IndexOf(barcoM, charToremove);
                                    tmp = new List<char>(barcoM);
                                    tmp.RemoveAt(numIdx);
                                    barcoM = tmp.ToArray();

                                    if (barcoP.Length == 0)
                                    {

                                        barco4 = true;

                                        Console.WriteLine("Tocado y hundido el barco M con 4 unidades");

                                    }
                                    else
                                    {
                                        Console.WriteLine("barco Tocado");

                                    }
                                    d = 8;
                                    break;

                                case 'T':

                                    charToremove = 'T';
                                    numIdx = Array.IndexOf(barcoT, charToremove);
                                    tmp = new List<char>(barcoT);
                                    tmp.RemoveAt(numIdx);
                                    barcoT = tmp.ToArray();

                                    if (barcoP.Length == 0)
                                    {

                                        barco3 = true;

                                        Console.WriteLine("Tocado y hundido el barco T con 3 unidades");

                                    }
                                    else
                                    {
                                        Console.WriteLine("barco Tocado");

                                    }
                                    d = 8;
                                    break;

                                case 'R':

                                    charToremove = 'R';
                                    numIdx = Array.IndexOf(barcoR, charToremove);
                                    tmp = new List<char>(barcoR);
                                    tmp.RemoveAt(numIdx);
                                    barcoR = tmp.ToArray();

                                    if (barcoP.Length == 0)
                                    {

                                        barco2 = true;

                                        Console.WriteLine("Tocado y hundido el barco R con 2 unidades");

                                    }
                                    else
                                    {
                                        Console.WriteLine("barco Tocado");

                                    }
                                    d = 8;
                                    break;



                                    


                            }

                            contador++;

                        }
                        else
                        {


                            Console.WriteLine("Tu disparo se ha ido al agua");

                            contador++;


                        }



                    }
                    else
                    {



                    }






                }






            } while (contador != 40 | barco2 != true & barco3 != true & barco4 != true & barco5 != true);

            if(contador == 40)
            {

                Console.WriteLine(" se acabo el juego no has conseguido undir los barcos");


            }
            else
            {

                Console.WriteLine(" Muy Bien has consegui Hundir todos los Barcos has GANADO");


            }


            Console.WriteLine("Pulsa cualquier tecla para cerrar el programa");
            Console.ReadLine();

        }
    }
}
