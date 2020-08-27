using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operas
{
    class Program
    {
        static operaciones operasd = new operaciones();

        static Menu m = new Menu();



        static void Main(string[] args)

        {

            int opciones = 0;



            while (opciones != 4)

            {

                opciones = m.ListaMenu();

                if (opciones == 1)

                {

                    Console.WriteLine(operasd.Resultado('s'));



                }

                else if (opciones == 2)

                {

                    Console.WriteLine(operasd.Resultado('r'));

                }

                else if (opciones == 3)

                {

                    Console.WriteLine(operasd.Resultado('m'));

                }

                else if (opciones == 4)

                {

                    Console.WriteLine(operasd.Resultado('d'));

                }

                else if (opciones == 5)

                {

                    Console.WriteLine(operasd.Resultado('p'));

                }

                else if (opciones == 6)

                {

                    Console.WriteLine(operasd.Resultado('i'));

                }
            }





            Console.ReadKey();

        }





    }
}
