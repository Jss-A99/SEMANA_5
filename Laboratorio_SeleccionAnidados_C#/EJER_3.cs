using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_SeleccionAnidados_C_
{
    internal class EJER_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--- PRÉSTAMOS Y CUOTAS ---");
            Console.Write("\nIngrese el monto del préstamo: ");
            double prest = double.Parse(Console.ReadLine());

            int cuot = 0;
            double inter;
            if (prest <= 5000) cuot = 2; inter = 0.05 * prest;
            if (prest <= 10000) cuot = 4; inter = 0.05 * prest;
            if (prest <= 15000) cuot = 6; inter = 0.03 * prest;
            if (prest > 15000) cuot = 10; inter = 0.03 * prest;

            double cuotmen = (prest + inter) / cuot;

            Console.WriteLine("\n--------------------");
            Console.WriteLine($"N° Cuotas: {cuot}");
            Console.WriteLine($"Cuota mensual: S/{cuotmen:N2}");
            Console.WriteLine($"Interés aplicado: S/{inter:N2}");
        }
    }
}
