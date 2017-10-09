using System;

namespace Primero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola todos!");
            string nombre = "Sabrina";
            string SegundoNombre;
            SegundoNombre = "Paula";
            //Se puede hacer todo de una como el primer nombre o se puede hacer en dos pasos como el 2do...

            Console.WriteLine("Mi nombre es: " + nombre + " " + SegundoNombre);

            int edad = 29;
            //bool existe = true;
            //char letra = 'A';

            if(edad >= 18)
            {
                Console.WriteLine("Soy mayor de edad.");
            }
            else
            {
                Console.WriteLine("Soy menor de edad");
            }
            Console.WriteLine("Cantidades de parámetros:" + args.Length);
            switch(args.Length)
            
            {
                case 0:
                    Console.WriteLine("No tiene parámetros");
                    break;
                case 1:
                    Console.WriteLine("Tiene un parámetro");
                    break;
                default:
                    Console.WriteLine("Tiene" + args.Length + " parámetros");
                    break;
                /* 
                Comentario
                Multilinea
                Bitches
                 */
            }


        }
    }
}
