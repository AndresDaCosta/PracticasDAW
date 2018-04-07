using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoCesar
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos dos array de Char, uno para mayusculas y otro para minusculas
            Char[] alfabetoM = new Char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Char[] alfabetom = new Char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            
            //pedimos la cadena que se quiere encriptar
            Console.WriteLine("Escriba lo que desea encriptar");

            String In = Console.ReadLine();

            //convertimos la cadena en un array de Char
            Char[] inChar = In.ToCharArray();
            
            //creamos el Array de char para el cifrado Cesar
            Char[] CharOut = new Char[In.Length];

            //control para el cifrado Cesar.
            for (int i = 0; i < inChar.Length; i++)
            {
                //identificacion de los espacios de la cadena original.
                if ( inChar[i] == ' ')
                {
                    CharOut[i] = ' ';
                }
                else
                {
                    // si no tiene espacio se pasa al control de Mayusculas y minusculas
                    //empezamos con las mayusculas
                    for(int x = 0; x < alfabetoM.Length; x++)
                    {
                        //control para recorrer el array de Mayusculas.
                        if(alfabetoM[x] == inChar[i])
                        {
                            //si es mayuscula se sustituye por la letra de la posicion actual + 3 de posicion 
                            CharOut[i] = alfabetoM[x + 3];
                        }
                        else
                        {
                            // si no es igual no se hace nada y sa pasa al siguiente repeticion                    
                        }

                    }

                    //bucle para recorrer las minusculas
                    for (int z = 0; z < alfabetom.Length; z++)
                    {
                        //control de comparacion
                        if (alfabetom[z] == inChar[i])
                        {
                            //si es mayuscula se sustituye por la letra de la posicion actual + 3 de posicion
                            CharOut[i] = alfabetoM[z + 3];
                        }
                        else
                        {
                            // si no es igual no se hace nada y sa pasa al siguiente repeticion  
                        }

                    }




                }




            }

            //se convierte CharOut en un string
            String cadenaOut = new String(CharOut);

            //se imprime en pantalla el string que es el encriptado.
            Console.WriteLine("su cadena encriptada es: " + cadenaOut);
            Console.ReadLine();



        }
    }
}
