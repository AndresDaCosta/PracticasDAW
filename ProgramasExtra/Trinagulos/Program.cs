using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinagulos
{
    class Program
    {
        static void Main(string[] args)
        {

            int Base = new int();
            int altura = new int();
            int area = new int();

            Console.WriteLine("Introduce la Base del triangulo:  ");

            Base = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la altura del Triangulo: ");

            altura = int.Parse(Console.ReadLine());

            area = (Base * altura) / 2;

            Console.WriteLine("el area de tu triangulo es: " + area);
            Console.ReadLine();







        }
    }
}
