using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operas
{
    class Menu
    {
        private int op = 0;



        public int ListaMenu()

        {

            Console.WriteLine("1.- suma");

            Console.WriteLine("2.- resta");

            Console.WriteLine("3.- multiplicacion");

            Console.WriteLine("4.- division");

            Console.WriteLine("5.- potenciacion");

            Console.WriteLine("6.- raiz cuadrada");

            Console.WriteLine("7.- salir");

            Console.Write("Opcion: ");

            op = int.Parse(Console.ReadLine());

            return op;

        }

    }
}

