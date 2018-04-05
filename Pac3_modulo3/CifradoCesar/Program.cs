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

            Char[] CharOut = new Char[In.Length];

            for (int i = 0; i < inChar.Length; i++)
            {

                if ( inChar[i] == ' ')
                {
                    CharOut[i] = ' ';
                }
                else
                {
                    for(int x = 0; x < alfabetoM.Length; x++)
                    {

                        if(alfabetoM[x] == inChar[i])
                        {
                            CharOut[i] = alfabetoM[x + 3];
                        }
                        else
                        {
                                                
                        }

                    }

                    for (int z = 0; z < alfabetom.Length; z++)
                    {

                        if (alfabetom[z] == inChar[i])
                        {
                            CharOut[i] = alfabetoM[z + 3];
                        }
                        else
                        {

                        }

                    }




                }




            }

            String cadenaOut = new String(CharOut);

            Console.WriteLine("su cadena encriptada es: " + cadenaOut);
            Console.ReadLine();



        }
    }
}
