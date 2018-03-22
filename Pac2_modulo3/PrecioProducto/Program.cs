using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecioProducto
{
    class Program
    {
        static void Main(string[] args)
        {

            Double Precio_Patatas = new Double();
            Double Kilos = new Double();
            Double Precio_Bruto = new Double();
            Double Precio_Descuento = new Double();
            Double Precio_Final = new Double();
            String Tipo = "";
            Boolean Des_100 = false;
            Boolean Des_50 = false;
            Boolean Iva = false;

            Console.WriteLine("Bienvenido Sr ");
            Console.WriteLine("Cuantos Kilos de patatas va a vender");

            Kilos = Double.Parse(Console.ReadLine());
            Precio_Patatas = 2.7;

            Console.WriteLine("Es para un 'Particular' o una 'Empresa'");

            Tipo = Console.ReadLine();

            Precio_Bruto = Kilos * Precio_Patatas;

            if(Precio_Bruto > 50)
            {

                if(Precio_Bruto > 100)
                {

                    Precio_Descuento = (Precio_Bruto - ((Precio_Bruto * 20) / 100));

                    Des_100 = true;

                }
                else
                {

                    Precio_Descuento = (Precio_Bruto - ((Precio_Bruto * 10) / 100));

                    Des_50 = true;
                }

            }
            else
            {

                Precio_Descuento = Precio_Bruto;

            }
            if (Tipo.Equals("Empresa"))
            {

                Precio_Final = (Precio_Descuento - ((Precio_Descuento * 21) / 100));

                Iva = true;

            }
            else
            {

                Precio_Final = Precio_Descuento;

            }

            if(Des_100 == true)
            {

                if(Iva == true)
                {
                    Console.WriteLine("Detalle Compra");
                    Console.WriteLine("Precio Bruto: " + Precio_Bruto);
                    Console.WriteLine("Descuento: " + "20%");
                    Console.WriteLine("Precio con descuento: " + Precio_Descuento);
                    Console.WriteLine("Sin IVA (21%)");
                    Console.WriteLine("Precio TOTAL: " + Precio_Final);


                }
                else
                {
                    Console.WriteLine("Detalle Compra");
                    Console.WriteLine("Precio Bruto: " + Precio_Bruto);
                    Console.WriteLine("Descuento: " + "20%");
                    Console.WriteLine("Precio con descuento: " + Precio_Descuento);
                    Console.WriteLine("Iva 21%");
                    Console.WriteLine("Precio TOTAL: " + Precio_Final);

                }

            }
            else
            {
                if(Iva == true)
                {
                    Console.WriteLine("Detalle Compra");
                    Console.WriteLine("Precio Bruto: " + Precio_Bruto);
                    Console.WriteLine("Descuento: " + "10%");
                    Console.WriteLine("Precio con descuento: " + Precio_Descuento);
                    Console.WriteLine("Sin IVA (21%)");
                    Console.WriteLine("Precio TOTAL: " + Precio_Final);

                }
                else
                {
                    Console.WriteLine("Detalle Compra");
                    Console.WriteLine("Precio Bruto: " + Precio_Bruto);
                    Console.WriteLine("Descuento: " + "20%");
                    Console.WriteLine("Precio con descuento: " + Precio_Descuento);
                    Console.WriteLine("Iva 21%");
                    Console.WriteLine("Precio TOTAL: " + Precio_Final);


                }


            }


            Console.ReadLine();



            


            





             
             


        }
    }
}
