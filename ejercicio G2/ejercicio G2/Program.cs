using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_G2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            byte edad;
            string sexo;
           
            Console.WriteLine("ingrese nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese la edad");
            edad = byte.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el sexo Masculino=m y femenino=f");
            sexo = Console.ReadLine();


            if (sexo == "m")
            {

                Console.WriteLine("el Sr." + nombre + " se ha registrado");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("La Sra." + nombre + " se ha sido registrada");
                Console.ReadLine();
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("\n----->Fin del programa");
            Console.ReadKey();
        }
    }
}
