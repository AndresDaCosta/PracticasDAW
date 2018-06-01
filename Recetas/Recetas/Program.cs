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

            String Ingredientes = Console.ReadLine();


            Normalice(Ingredientes);

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

            FileStream Connect = new FileStream(path, FileMode.Open);

            BinaryReader ConnectBinario = new BinaryReader(Connect, Encoding.UTF8);

            String result = ConnectBinario.ReadString();

            Console.ReadLine();




        }
       

    }
}
