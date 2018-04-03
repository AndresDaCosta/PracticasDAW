using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realiza un programa que permita al usuario introducir una cadena, cuente los
                caracteres que tiene y la cantidad de letras ‘a’ que tiene. Después, el usuario podrá
                    introducir una letra, y le dirá en qué posiciones aparece.*/
            
            //pedimos la cadena de caracteres
            Console.WriteLine("Por favor introduzca una cadena de caracteres:  ");
            
            //guardamos la cadena en un String y lo desglosamos los caracteres en un array de Char
            String cadena = Console.ReadLine();
            Char[] desglose = cadena.ToArray();
            int A_conteo = new int();
            Char Busca = new Char();
            

            //Control de identificacion de las letras.
            for (int i = 0; i < desglose.Length; i ++)
            {

                if (desglose[i] == 'a' )
                {

                    A_conteo ++;

                }

            }

            //resultados del primer control del Array
            Console.WriteLine("su cadena tiene la letar a " + A_conteo + " veces");
            Console.WriteLine("su cadena tiene " + desglose.Length + " caracteres");

            //solicitamos un caracter para buscar
            Console.WriteLine("Escriba una letra para saber en que posicion aparece en su cadena");

            //Guardamos el caracter en en Char Busca
            Busca = Char.Parse(Console.ReadLine());

            //control que recorre todo el array de Char para buscar la letra introducida por el usuario.
            for (int x = 0; x < desglose.Length; x ++)
            {
                if (desglose[x].Equals(Busca))
                {

                    //igualamos conteo a la posicion del array y se le suma 1 ya que el array empieza en 0
                    A_conteo = x + 1;

                    //salida cada vez que aparece el caracter
                    Console.WriteLine("El caracter " + Busca + " aparece en la poscion " + A_conteo + " del array");

                }

            }

            //fin
            Console.WriteLine("Programa finalizado pulse cualquier tecla para acabar ");
            Console.ReadLine();


        }
    }
}
