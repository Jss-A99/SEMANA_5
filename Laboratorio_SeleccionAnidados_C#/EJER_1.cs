using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_SeleccionAnidados_C_
{
    internal class EJER_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--- CLASIFICACIÓN DEL ÁNGULO ---");
            Console.Write("\nIngrese la medida del ángulo(0° - 360°): ");
            double ang = Convert.ToDouble(Console.ReadLine());

            string clas;

            if (ang == 0)
                clas = "Nulo";
            else if (ang > 0 & ang < 90)
                clas = "Agudo";
            else if (ang == 90)
                clas = "Recto";
            else if (ang > 90 & ang < 180)
                clas = "Obtuso";
            else if (ang == 180)
                clas = "Llano";
            else if (ang > 180 && ang < 360)
                clas = "Cóncavo";
            else if (ang == 360)
                clas = "Completo";
            else
                clas = "Inválido";

            Console.WriteLine($"Clasificación: {clas}");
        }
    }
}
