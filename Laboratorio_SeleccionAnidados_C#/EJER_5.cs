using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_SeleccionAnidados_C_
{
    internal class EJER_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--- CLASIFICACIÓN DE USUARIO ---");
            Console.Write("\nIngrese la cantidad de comentarios: ");
            int men = int.Parse(Console.ReadLine());

            string clas;

            if (men < 0) clas = "Error: Valor negativo";
            else if (men <= 49) clas = "Desconocido";
            else if (men <= 99) clas = "Humano";
            else if (men <= 249) clas = "Dicionius Inicial";
            else if (men <= 499) clas = "Dicionius Novato";
            else if (men <= 999) clas = "Dicionius Experimentado";
            else if (men <= 1999) clas = "Dicionius Elite";
            else if (men <= 4999) clas = "Dicionius Definitivo";
            else clas = "Dicionius Legendario";

            Console.WriteLine("\n-------------------------");
            Console.WriteLine($"Su clasificación es {clas}.");
        }
    }
}
