using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundirLaFlota
{
    class Program
    {
        static void Main(string[] args)
        {
            /*programa hundir la flota*/

            /*Output de la primera posicion*/
          
            for ( int i = 0; i <= 10; i++)
            {
                Console.WriteLine("+---++---++---++---++---++---++---++---++---++---++----+");
                for (int x = 0; x <= 10; x++)
                {
                    
                    if ( i == 0)
                    {

                        Console.Write("| " + x + " |");    

                    }
                    else
                    {
                        if (x == 0)
                        {
                            Console.Write("| " + i + " |");
                        }
                        else
                        {
                            Console.Write("| " + " " + " |");
                        }

                        

                    }


                   
                }

                Console.WriteLine();
                

                

            }
            Console.WriteLine("+---++---++---++---++---++---++---++---++---++---++----+");
            Console.ReadLine();

            
        }
    }
}
