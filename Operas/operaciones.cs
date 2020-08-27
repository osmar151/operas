using System;

namespace Operas
{
    class operaciones
    {
        public suma opera = new suma();
        public resta oper = new resta();
        public multiplicacion operas = new multiplicacion();
        public division ope = new division();
        public potencias opers = new potencias();
        public radicacion opersb = new radicacion();

        public double n = 0;



        public string Resultado(char t)

        {

            double total = 0;



            char op = 's';





            while (op != 'n')

            {

                if (t == 's')

                {

                    total = opera.Suma(total, Pedir());

                }

                else if (t == 'r')

                {

                    total = oper.Resta(total, Pedir());

                }

                else if (t == 'm')

                {

                    total = operas.Multiplicacion(total, Pedir());

                }

                else if (t == 'd')

                {

                    total = ope.Divicion(total, Pedir());

                }

                else if (t == 'p')

                {

                    total = opers.Potenciacion(total, Pedir());

                }

                else if (t == 'i')

                {

                    total = opersb.Radicacion(total, Pedir());

                }

                Console.Write("desea ingresar otro valor [s/n] ");

                op = char.Parse(Console.ReadLine());

            }



            return ("el resultado es: " + total);

        }



        private double Pedir()

        {

            double valor = 0;

            bool estado = false;



            while (estado == false)

            {

                Console.Write("ingrese un valor: ");

                try

                {

                    valor = double.Parse(Console.ReadLine());

                    estado = true;

                }

                catch

                {

                    Console.WriteLine("ingrese valores numericos...");

                }

            }


            return valor;

        }



    }
}

