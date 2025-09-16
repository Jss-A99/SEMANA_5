using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace JP_Ejercicios_S5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EJER_1();
            Console.ReadLine();
        }
        static void EJER_1()
        {
            Console.WriteLine("\n--- ELEGIBLE PARA VOTACIÓN Y CANDIDATO ---");
            Console.Write("\nIngrese su edad: ");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("\n-----------------------------------");
            if (e < 18) Console.WriteLine("No tiene la edad mínima para votar ni para ser candidato a un cargo político.");
            else if (e >= 25) Console.WriteLine("Tiene la edad para votar y ser candidato a un cargo político.");
            else Console.WriteLine("Tiene la edad para votar, pero no para ser candidato.");
        }
    }
}
