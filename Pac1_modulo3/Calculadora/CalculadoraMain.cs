using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class CalculadoraMain
    {
        static void Main(string[] args)
        {
            //se solicita al usuario el 1º valor para operarlo

            Console.WriteLine("Por favor introduce el 1º valor: ");

            String Num = Console.ReadLine();
            int Num1 = int.Parse(Num);    // se convierte el string que entrega la consola en un int

            //se pide el segundo valor

            Console.WriteLine("Por favor introduce el segundo valor: ");

            String Num2 = Console.ReadLine();
            int Num2_2 = int.Parse(Num2);    // se convierte un el segundo valor en int.

            // se realizan la diferentes operaciones

            int suma = Num1 + Num2_2;
            int resta = Num1 - Num2_2;
            int multipica = Num1 * Num2_2;
            int dividir = Num1 / Num2_2;

            Console.WriteLine("suma: " + suma);
            Console.WriteLine("resta " + resta);
            Console.WriteLine("multiplicacion " + multipica);
            Console.WriteLine("dividision " + dividir);

            Console.WriteLine("pulsa cualquier tecla para acbar: ");
            Console.ReadLine();
        }
    }
}
