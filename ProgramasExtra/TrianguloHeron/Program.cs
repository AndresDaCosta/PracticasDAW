using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloHeron
{
    class Program
    {
        static void Main(string[] args)
        {

            Double LadoA = new Double();
            Double LadoB= new Double();
            Double LadoC = new Double();
            Double SemiPe = new Double();
            Double Area = new Double();

            Console.WriteLine("Introduce el valor del lado A");
            LadoA = Double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el valor del lado B");
            LadoB = Double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el valor del lado C");
            LadoC = Double.Parse(Console.ReadLine());

            SemiPe = (LadoA + LadoB + LadoC) / 2;

            Area = Math.Sqrt(SemiPe * (SemiPe - LadoA) * (SemiPe * LadoB) * (SemiPe * LadoC));

            Console.WriteLine("El area de su trinagulo es: " + Area);

            Console.ReadLine();

        




        }
    }
}
