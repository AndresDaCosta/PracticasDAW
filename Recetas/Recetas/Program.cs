using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetas
{
    class Program
    {

        static void Main(string[] args)
        {

            /*programa de las recetas*/
            

            /*se crea un array de tipo string para  los ingredientes que introduce el ussuario*/
            String[] Ingredi = new String[10];
            
            /*llamamos a la funcion introduce paa que el usuario introduzca  los ingredientes*/
            Introduce(ref Ingredi);

            //comparamos los ingredientes que nos pasa el usuario.
            compare(Ingredi);


        }

        //funcion que solicita al usuario los ingredientes
        static void Introduce(ref String [] Ingredi)
        {
            //pedimos al usuario que nos indique los ingredientes
            Console.WriteLine("introduce los ingredientes separados por comas:  ");

            //guradamos los ingrdientes en un String
             String Ingredientes = " " + Console.ReadLine();

            //llamamos a la funcion normalice para separarar idividualmente los ingredientes
            Ingredi = Normalice(Ingredientes);

        }
        //funcion normaliced lo que hace es divbidir los ingredientes separados por comas y meterlos en un ARRAY de string 
        //se pasa por parametro los ingredientes que el usuario a introducido en  el programa
        static String[] Normalice( String In)
        {

            //con los ingredientes se hace un array de tipo String para meter los ingredientes con un split por la coma
            String[] InNormaliced = In.Split(',');

            //devolvemos  el array creado 
            return InNormaliced;

        }
        //la funcion compare los ue hace es comparar los ingredientes que ha introducido el usuario con los de la lista del archivo guardado.
        static void compare(String [] Lista)
        {
            String path = ReadPaths();

            String line; 

            StreamReader Read = new StreamReader(path);

            while((line = Read.ReadLine()) != null)
            {
                int positivo = new int();

                String[] Divide = line.Split(':');

                Divide[0] = "";

                String temp = String.Join(" ", Divide);

                Divide = temp.Split(',');

                for (int x = 0; x < Lista.Length; x++)
                {

                    if(Array.IndexOf(Divide, Lista[x]) >= 0)
                    {

                        positivo++;


                    }
                    else
                    {


                    }


                }


                if (positivo  == Divide.Length)
                {

                    Console.WriteLine("se ha ejecutado correctamente");

                    Write(line);
                }
                else
                {

                }


            }


            Read.Close();


        }
        static  void Write( String Line )
        {
            String path = WritePaths();

            StreamWriter Write = File.CreateText(path);


            Write.WriteLine(Line);

            Write.Close();

            Console.WriteLine("Se ha escrito las posibles recetas en en archivo ");

        }
        static String WritePaths()
        {

            String path = @"..\Recetas\posibles.txt";

            return path;
        }
        static String ReadPaths()
        {

            String path = @"..\Recetas\recetas.txt";

            return path;
        }

    }
}
