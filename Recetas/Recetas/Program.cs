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
            // recogemos la ruta desde el metodo readpaths
            String path = ReadPaths();

            //creamos un string para la linea que vamos a leer
            String line;

            //creamos el streamreader
            StreamReader Read = new StreamReader(path);

            //mientras  la igualdad de line el read line del documento no sea nulo
            while((line = Read.ReadLine()) != null)
            {
                //creamos un contador
                int positivo = new int();

                // hamos split de la liea para quitarle el titulo de la receta
                String[] Divide = line.Split(':');
                //sustituimos el titulo por nada
                Divide[0] = "";

                // hacemos el array de nuevo a string 
                String temp = String.Join(" ", Divide);
                
                //hacemos de nuevo split por la coma para separar los ingredientes
                Divide = temp.Split(',');

                //por por casa ingrediente de la lista se compara con el array divide de los de la receta
                for (int x = 0; x < Lista.Length; x++)
                {

                    if(Array.IndexOf(Divide, Lista[x]) >= 0)
                    {
                        // si son iguales se suma el contador
                        positivo++;


                    }
                    else
                    {

                        // si no no hacemos nada

                    }


                }

                // si positivo es igual a la largura del array 
                if (positivo  == Divide.Length)
                {
                    // escribimos un mensaje
                    Console.WriteLine("se ha ejecutado correctamente");

                    //se llama a la funcion write line
                    Write(line);
                }
                else
                {

                }


            }

            // cerramos la lectura del archivo
            Read.Close();


        }
        //funcion write   se recibe una linea para escribirla en el documento
        static  void Write( String Line )
        {
            // buscamos el path para escribir el nuevo archivo
            String path = WritePaths();

            //creamos un nuevo archivo
            StreamWriter Write = File.CreateText(path);

            // escribimos la linea en el documento 
            Write.WriteLine(Line);

            // cerramos la escritura
            Write.Close();

            Console.WriteLine("Se ha escrito las posibles recetas en en archivo ");

        }
        static String WritePaths()
        {

            String path = @"..\..\posibles.txt";

            return path;
        }
        static String ReadPaths()
        {

            String path = @"..\..\recetas.txt";

            return path;
        }

    }
}
