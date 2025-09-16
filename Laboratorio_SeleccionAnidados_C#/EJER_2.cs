using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_SeleccionAnidados_C_
{
    internal class EJER_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--- CÁLCULO DE PENSIÓN ---");
            Console.Write("\nIngrese su categoría de estudiante (A, B, C, D): ");
            string cat = Console.ReadLine().ToLower();
            Console.Write("Ingrese su promedio ponderado del ciclo anterior: ");
            double prom = double.Parse(Console.ReadLine());

            double pension;
            switch(cat)
            {
                case "a": pension = 550; break;
                case "b": pension = 500; break;
                case "c": pension = 460; break;
                case "d": pension = 400; break;
                default: Console.WriteLine("Error. Categoría inválida."); return;
            }
            double desc = 0;
            if (prom <= 13.99) desc = 0;
            else if (prom <= 15.99) desc = 0.10 * pension;
            else if (prom <= 17.99) desc = 0.12 * pension;
            else if (prom <= 20) desc = 0.15 * pension;
            double pensionf = pension - desc;
            
            Console.WriteLine("\n-----------------------");
            Console.WriteLine($"Pensión actual: S/{pension:N2}.");
            Console.WriteLine($"Descuento: S/{desc:N2}");
            Console.WriteLine($"Pensión a pagar: S/{pensionf:N2}.");
        }
    }
}
