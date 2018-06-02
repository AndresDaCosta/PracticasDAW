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

            String[] Ingredi = new String[10];
 
            Introduce(ref Ingredi);

            compare(Ingredi);


        }
        static void Introduce(ref String [] Ingredi)
        {

            Console.WriteLine("introduce los ingredientes separados por comas:  ");

             String Ingredientes = " " + Console.ReadLine();


            Ingredi = Normalice(Ingredientes);

        }
        static String[] Normalice( String In)
        {

            int index = new int();

            

            String[] InNormaliced = In.Split(',');

            Console.ReadLine();

            return InNormaliced;

        }
        static void compare(String [] Lista)
        {
            String path = @"C:\Users\612072594\Documents\formacion\Grado supeior\Recetas\Recetas\recetas.txt";

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
            String path = @"C:\Users\612072594\Documents\formacion\Grado supeior\Recetas\Recetas\posibles.txt";

            StreamWriter Write = File.CreateText(path);


            Write.WriteLine(Line);

            Write.Close();

            

        }
       

    }
}
