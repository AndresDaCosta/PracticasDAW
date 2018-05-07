using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcelas
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Tenemos un campo de 500 m2 y queremos cercarlo. El precio de cada metro de
            valla es de 15€. Antes de llegar el presupuesto, viene el vecino con la oferta de
            vendernos la parcela que linda con la nuestra.
                - Crea una función que permita al vecino introducir el número de metros que nos
                    vende, y el precio que aporta.
            A nosotros esta tierra nos gusta mucho, así que aceptamos. La función debe
            devolver el número de metros actuales de nuestro campo actualmente (metros
            que ya tenía + metros que nos vende) y devuelve también el precio que
            llevamos gastado en este proceso.
                - Crea otra función que sume el precio que tenemos que pagar por toda la
            operación, es decir, tanto la compra de la parcela de al lado junto con el cercado
            de todo nuestro campo.
            En el programa principal, se mostrará el número actual de metros cuadrados, y el
            coste total de la operación.*/

            int mi_parcela = new int();
            int vend_parcela = new int();
            int prec_cerca = new int();
            double parcela_total = new double();
            double precio_venta = new double();
            double precio_tot = new double();
            double total = new double();
            prec_cerca = 15;
            mi_parcela = 500;


            Vendedor(ref mi_parcela, ref prec_cerca, ref vend_parcela, out parcela_total, out precio_venta, out precio_tot);

            Console.WriteLine("el vecino te vendio " + vend_parcela + " metros cuadrados por un precio " + precio_venta + " euros");

            Console.WriteLine("tu parcela total sera de " + parcela_total + " metros cuadrados");
            Console.WriteLine("te has gastado en este proceso " + precio_tot + " euros en la compra de la parcela y el cercado del terreno que ya tenias");

            Operacion_tot(ref parcela_total, ref precio_venta, ref prec_cerca, out total);

            Console.WriteLine("el precio total de la operacion sera " + total + "esto incluye el precio del nuevo terreno y el cercado del terreno toral");


        }

        static void Vendedor(ref int  mi_parcela, ref int prec_cerca, ref int vend_parcela, out double parcela_total, out double precio_venta, out double precio_tot )
        {

            Console.WriteLine("Por favor introduce el numero de metros que quieres vender ");
            vend_parcela = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor introduce el precio e la venta de ese terreno");
            precio_venta = double.Parse(Console.ReadLine());


            parcela_total = vend_parcela + mi_parcela;

            precio_tot = (prec_cerca * mi_parcela) + precio_venta;
          
                      

        }
        static void Operacion_tot(ref double parcela_total, ref double precio_venta, ref int prec_cerca, out double total)
        {

            total = (parcela_total * prec_cerca) + precio_venta;



        }
    }
}
