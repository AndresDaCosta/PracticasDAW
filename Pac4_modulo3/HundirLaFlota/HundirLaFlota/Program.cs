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

            /*integrantes del tablero del juego*/
            char[,] tablero = new char[11, 8];
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            /*contadores auxiliares*/
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
            /*Seleccion del barco*/
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

            do
            {

                /*bucle do que acabara cuando todos lo barcos esten a True
                 */

                /*Limpiamos consola*/
                Console.Clear();
                /*Menu de seleccion de los barcos*/
                Console.WriteLine("barcos disponibles");
                Console.WriteLine("1- Barco P longitud " + barcoP.Length);
                Console.WriteLine("2- Barco M longitud " + barcoM.Length);
                Console.WriteLine("3- Barco T longitud " + barcoT.Length);
                Console.WriteLine("4- Barco R longitud " + barcoR.Length);
                Console.WriteLine("Elije el barco que quieres con el numero del menu.");

                /*switch para la seleccion de los barcos*/
                switch (int.Parse(Console.ReadLine()))
                {

                    case 1:

                        if(barco5 = true){

                            //barco ya seleccionado no se puede seleccionar el mismo barco 2 veces
                            Console.WriteLine("barco ya registrado, por favor selecciona otro");

                        }
                        else
                        {

                            /*barco de longitud 5*/
                            Console.WriteLine("has elejido el barco P con longitud " + barcoP.Length);
                            // igualamos el barco seleccionado al barco en que se ha escogido
                            barcoSE = barcoP;
                            //pasamos el barco 5 a true para que no se vuelva a seleccionar
                            barco5 = true;


                        }
                        
                        break;

                    case 2:
                        if (barco4 = true){

                            //barco ya seleccionado no se puede seleccionar el mismo barco 2 veces
                            Console.WriteLine("barco ya registrado, por favor selecciona otro");


                        }
                        else
                        {
                            /*barco de longitud 4*/
                            Console.WriteLine("has elejido el barco M con longitud " + barcoM.Length);
                            // igualamos el barco seleccionado al barco en que se ha escogido
                            barcoSE = barcoP;
                            //pasamos el barco 4 a true para que no se vuelva a seleccionar
                            barco4 = true;
                        }
                                                
                        break;
                    case 3:

                        if (barco3 = true)
                        {
                            //barco ya seleccionado no se puede seleccionar el mismo barco 2 veces
                            Console.WriteLine("barco ya registrado, por favor selecciona otro");

                        }
                        else
                        {
                            /*barco de longitud 3*/
                            Console.WriteLine("has elejido el barco T con longitud " + barcoT.Length);
                            // igualamos el barco seleccionado al barco en que se ha escogido
                            barcoSE = barcoT;
                            //pasamos el barco 3 a true para que no se vuelva a seleccionar
                            barco3 = true;
                        }
                                             
                        break;
                    case 4:


                        if (barco2 = true)
                        {
                            //barco ya seleccionado no se puede seleccionar el mismo barco 2 veces
                            Console.WriteLine("barco ya registrado, por favor selecciona otro");

                        }
                        else
                        {
                            /*barco de longitud 2*/
                            Console.WriteLine("has elejido el barco R con longitud " + barcoR.Length);
                            // igualamos el barco seleccionado al barco en que se ha escogido
                            barcoSE = barcoR;
                            //pasamos el barco 2 a true para que no se vuelva a seleccionar
                            barco2 = true;
                        }
                       
                        break;

                }

                // selecciona si en vertical o horizontal
                Console.WriteLine("Como lo quieres poner Vertical o Horizontal ?");
                String option = Console.ReadLine();

                //vemos si se ha escogido vertical
                // cambiamos el option
                if (option == "vertical")
                {
                    vertical = true;
                }
                else
                {
                    vertical = false;
                }

                // pedimos la coordenada al usuario
                Console.WriteLine("inserta las cordenada inicial del barco !LETRA EN MAYUSCULA!");

                // metemos la cordenada entera en un String
                String cordenada = Console.ReadLine();
                //convertimos el String en un array de char.
                char[] cordenadaCh = cordenada.ToArray();

                // comporbamos si se ha metido la columna 10  en la coordenada
                if (cordenadaCh.Length == 3)
                {
                    // si el array tiene mas de 3 se el numero de columna se pone a 10
                    corB = 10;
                }
                else
                {
                    // si no se pone con el numero que tiene el String
                    corB = int.Parse(cordenada.Substring(1));

                }


                // si se ha seleccionado vertical
                if (vertical == true & horizontal == false)
                {



                    Console.WriteLine("Quieres que se ponga hacia arriba o hacia abajo");

                    // se selecciona si el barco va hacia arriba o hacia abajo
                    if (Console.ReadLine() == "arriba")
                    {
                        // bucamos en fila el usuario quiere empezar con el barco 
                        for (int t = 0; t < 7; t++)
                        {
                            // se busca en el array de letras
                            if (cordenadaCh[0].Equals(letras[t]))
                            {
                                // si lo ha encontrado, vemos si el barco cabe
                                if (((t + 1) - barcoSE.Length) >= 0)
                                {
                                    // rellenamos la primera posicion del barco 
                                    tablero[corB, (t + 1)] = barcoSE[0];

                                    // creamos un bucle para rellenar el resto del barco en el tablero
                                    for (int u = 1; u <= (barcoSE.Length - 1); u++)
                                    {
                                        //cordenada de la fila para conpensar el indice del Array
                                        int p = (t + 1) - u;

                                        // se rellena la coordenada resultante con la letra que esta en el array del barco
                                        tablero[corB, p] = barcoSE[u];

                                    }

                                    // cortamos el bucle
                                    t = 8;
                                }
                                else
                                {
                                    // si el barco no cabe

                                    Console.WriteLine("El barco no cabe por favor cambia tus parametros");

                                    // se corta el bucle
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
                        
                        // si el barco va hacia abajo

                        for (int y = 0; y < 8; y++)
                        {

                            // de busca la fila como en el caso anterior
                            if (cordenadaCh[0].Equals(letras[y]))
                            {

                                // se hace una comparacion para ver si el barco cabe o no cabe
                                if (((y + 1) + barcoSE.Length) <= 8)
                                {
                                    // se rellena la primera posicion
                                    tablero[corB, (y + 1)] = barcoSE[0];

                                    // se realiza un bucle para rellenar el resto  del barco faltante

                                    for (int u = 1; u <= (barcoSE.Length - 1); u++)
                                    {

                                        // se buelve a conpensar el indice del array.
                                        int p = (y + 1) + u;

                                        // se marca en el tablero la letra del barco
                                        tablero[corB, p] = barcoSE[u];

                                    }

                                    // cerramos el bucle
                                    y = 9;
                                }


                            }
                            else
                            {

                                // si el barco no cabe.

                                Console.WriteLine("El barco no cabe por favor cambia tus parametros");

                                // se cierra el bucle
                                y = 8;

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
                                Console.WriteLine("El barco no cabe por favor cambia tus parametros");

                                m = 8;

                            }




                        }
                    }
                    else
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            if (cordenadaCh[0].Equals(letras[l]))
                            {

                                if (((corB) - barcoSE.Length) >= 0)
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
                                Console.WriteLine("El barco no cabe por favor cambia tus parametros");

                               l = 8;

                            }






                        }
                    }
                }



            } while (barco2 != true & barco3 != true & barco4 != true & barco5 != true);

            /*fin del atacado*/
            Console.WriteLine("Muy bien Jugador 1, has colocado todos los barcos. AHORA ES EL TURNO DEL ATACANTE. pulsa cualquier tecla para que empiece el juego");
            Console.ReadLine();
            Console.Clear();

            /*Reseteamos los checkeos para empezar con el atacante*/
             barco2 = false;
             barco3 = false;
             barco4 = false;
             barco5 = false;

            do
            {

                Console.WriteLine("Indica la cordenada para disparar");

                // se coge la coordena  que marca el usuario y se mete en un STRING

                String CordenadaAt = Console.ReadLine();

                // se pasa a un char como cuando el usuario 1 rellenaba el tablero
                char[] CordenadaCh = CordenadaAt.ToCharArray();

                // se repite el processo anterior para ver si se ha seleccionado la columna 10
                if (CordenadaCh.Length == 3)
                {
                   // si el array mide 3 se pone la cordenada B como 10
                   corBa = 10;
                }
                else
                {
                    // si el array no tiene 3 de longitud se selecciona el numero que marca
                    corBa = int.Parse(CordenadaAt.Substring(1));

                }



                // con este bucle se busca la columna de la coordenada para ver en cual se esta apuntado
                for (int d = 0; d < 7; d++)
                {
                    

                    // se compara los dos char
                    if (CordenadaCh[0].Equals(letras[d]))
                    {
                       // se compensa  la columnas de filas
                        int eje = d + 1;

                        // si el tablero no esta vacio en esa coordenada
                        if (tablero[corBa, eje] != '\0')
                        {

                            // se realiza un switch para ver de que barco se trata es casilla
                            switch(tablero[corBa, eje])
                            {

                                case 'P':

                                    // marcamos a borrar ese char
                                    char charToremove = 'P';
                                    // lo buscamos en el array del barco y marcamos su indice
                                    int numIdx = Array.IndexOf(barcoP, charToremove);
                                    //hacemos una lista temporal
                                    List<char> tmp = new List<char>(barcoP);
                                    // a esa lista temporal aplicamos el incide para borrar la letra
                                    tmp.RemoveAt(numIdx);
                                    // devolvemos la lista a un array
                                    barcoP = tmp.ToArray();
                                    
                                    if(barcoP.Length == 0)
                                    {
                                        // si la longitud del barco es 0 pues el barco esta eliminado "Hundido "

                                        // marcamos su contado para que ya no cuente
                                        barco5 = true;

                                        Console.WriteLine("Tocado y hundido el barco P con 5 unidades");

                                    }
                                    else
                                    {

                                        // si su longitud no es igual a 0 pues esta tocado
                                        Console.WriteLine("barco Tocado");

                                    }
                                    //cerramos el bucle de busqueda
                                    d = 8;

                                    break;

                                case 'M':

                                    // marcamos a borrar ese char
                                    charToremove = 'M';
                                    // lo buscamos en el array del barco y marcamos su indice
                                    numIdx = Array.IndexOf(barcoM, charToremove);
                                    //hacemos una lista temporal
                                    tmp = new List<char>(barcoM);
                                    // a esa lista temporal aplicamos el incide para borrar la letra
                                    tmp.RemoveAt(numIdx);
                                    // devolvemos la lista a un array
                                    barcoM = tmp.ToArray();

                                    if (barcoM.Length == 0)
                                    {
                                        // si la longitud del barco es 0 pues el barco esta eliminado "Hundido "

                                        // marcamos su contado para que ya no cuente

                                        barco4 = true;

                                        Console.WriteLine("Tocado y hundido el barco M con 4 unidades");

                                    }
                                    else
                                    {
                                        // si su longitud no es igual a 0 pues esta tocado

                                        Console.WriteLine("barco Tocado");

                                    }
                                    //cerramos el bucle de busqueda
                                    d = 8;
                                    break;

                                case 'T':

                                    // marcamos a borrar ese char
                                    charToremove = 'T';
                                    // lo buscamos en el array del barco y marcamos su indice
                                    numIdx = Array.IndexOf(barcoT, charToremove);
                                    //hacemos una lista temporal
                                    tmp = new List<char>(barcoT);
                                    // a esa lista temporal aplicamos el incide para borrar la letra
                                    tmp.RemoveAt(numIdx);
                                    // devolvemos la lista a un array
                                    barcoT = tmp.ToArray();

                                    if (barcoT.Length == 0)
                                    {
                                        // si la longitud del barco es 0 pues el barco esta eliminado "Hundido "

                                        // marcamos su contado para que ya no cuente

                                        barco3 = true;

                                        Console.WriteLine("Tocado y hundido el barco T con 3 unidades");

                                    }
                                    else
                                    {

                                        // si su longitud no es igual a 0 pues esta tocado

                                        Console.WriteLine("barco Tocado");

                                    }
                                    //cerramos el bucle de busqueda
                                    d = 8;
                                    break;

                                case 'R':

                                    // marcamos a borrar ese char
                                    charToremove = 'R';
                                    // lo buscamos en el array del barco y marcamos su indice
                                    numIdx = Array.IndexOf(barcoR, charToremove);
                                    //hacemos una lista temporal
                                    tmp = new List<char>(barcoR);
                                    // a esa lista temporal aplicamos el incide para borrar la letra
                                    tmp.RemoveAt(numIdx);
                                    // devolvemos la lista a un array
                                    barcoR = tmp.ToArray();

                                    if (barcoR.Length == 0)
                                    {
                                        // si la longitud del barco es 0 pues el barco esta eliminado "Hundido "

                                        // marcamos su contado para que ya no cuente

                                        barco2 = true;

                                        Console.WriteLine("Tocado y hundido el barco R con 2 unidades");

                                    }
                                    else
                                    {
                                        // si su longitud no es igual a 0 pues esta tocado

                                        Console.WriteLine("barco Tocado");

                                    }
                                    //cerramos el bucle de busqueda
                                    d = 8;
                                    break;



                                    


                            }

                            // cada vez que se completa el proceso pues se suma el contador de jugadas
                            contador++;

                        }
                        else
                        {

                            // si la casilla esta bacia su disparo se fue al agua

                            Console.WriteLine("Tu disparo se ha ido al agua");

                            // cada vez que se completa el proceso pues se suma el contador de jugadas
                            contador++;


                        }



                    }
                    else
                    {
                        // si la coordenada no se encuentra esque esta errada
                        Console.WriteLine("no se encuentra la cordenada que buscas, por favor vuelve a intentarlo.");


                    }






                }




                // el juego no acaba hasta que se hayan jugado 40 veces o todos lo barcos se undan

            } while (contador != 40 | barco2 != true & barco3 != true & barco4 != true & barco5 != true);

            if(contador == 40)
            {

                // si el contador ha llegado a 40 pues ha perdido

                Console.WriteLine(" se acabo el juego no has conseguido undir los barcos");


            }
            else
            {

                // si no ha ganado

                Console.WriteLine(" Muy Bien has consegui Hundir todos los Barcos en "+ contador +" jugadas,  has GANADO");


            }


            Console.WriteLine("Pulsa cualquier tecla para cerrar el programa");
            Console.ReadLine();

        }
    }
}
