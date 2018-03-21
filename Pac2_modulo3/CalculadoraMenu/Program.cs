using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMenu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor introduce el 1º valor: ");

            int Opcion = new int();
            int Resultado = new int();
            String Num = Console.ReadLine();
            int Num1 = int.Parse(Num);    // se convierte el string que entrega la consola en un int

            Console.WriteLine("que funcion quieres \r");
            Console.WriteLine("1 - Suma \r");
            Console.WriteLine("2 - Resta \r");
            Console.WriteLine("3 - Division \r");
            Console.WriteLine("4 - Multiplicacion \r");

            Opcion = int.Parse(Console.ReadLine());

            //se pide el segundo valor

            Console.WriteLine("Por favor introduce el segundo valor: ");

            String Num2 = Console.ReadLine();
            int Num2_2 = int.Parse(Num2);    // se convierte un el segundo valor en int.

            

            //opciones MENU

            switch (Opcion)
            {

                case 1:

                    Resultado = Num1 + Num2_2;

                    Console.WriteLine(Num1 + " + " + Num2_2 + " = " + Resultado);

                    break;

                case 2:

                    Resultado = Num1 - Num2_2;

                    Console.WriteLine(Num1 + " + " + Num2_2 + " = " + Resultado);

                    break;

                case 3:

                    Resultado = Num1 / Num2_2;

                    Console.WriteLine(Num1 + " / " + Num2_2 + " = " + Resultado);

                    break;

                case 4:

                    Resultado = Num1 * Num2_2;

                    Console.WriteLine(Num1 + " x " + Num2_2 + " = " + Resultado);

                    break;
                    
            }

            Console.WriteLine("pulsa cualquier tecla para acbar: ");
            Console.ReadLine();



        }
    }
}
