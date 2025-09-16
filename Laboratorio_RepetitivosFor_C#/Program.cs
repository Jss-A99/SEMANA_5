using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_RepetitivosFor_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EJER_8();
            Console.ReadLine();
        }
        static void EJER_1()
        {
            Console.WriteLine("\n--- IMPRIMIENDO JAVA ---");

            for (int i = 0; i < 3; i++) Console.WriteLine("Java.");
        }
        static void EJER_2()
        {
            Console.WriteLine("\n--- TABLA DEL CINCO ---");
            Console.Write("\n¿Hasta qué número desea la tabla del 5?: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("\n-------------------");
            for (int i = 0; i <= num; i++)
            {
                int r = i * 5;
                Console.WriteLine($"5 x {i} = {r}");
            }
        }
        static void EJER_3()
        {
            Console.WriteLine("\n--- TU TABLA DE MULTIPLICACIÓN ---");
            Console.Write("\n¿Qué tabla deseas?: ");
            int tb = int.Parse(Console.ReadLine());
            Console.Write("¿Hasta qué número quieres tu tabla?: ");
            int lim = int.Parse(Console.ReadLine());

            Console.WriteLine("\n-------------------");
            for (int i = 0;i <= lim; i++)
            {
                int r = i * tb;
                Console.WriteLine($"{tb} x {i} = {r}");
            }
        }
        static void EJER_4()
        {
            Console.WriteLine("\n--- GENERANDO NÚMEROS IMPARES HASTA EL 100 ---");
            Console.WriteLine("\n--------------------------");

            for (int i = 1; i <= 100; i += 2)
            {
                Console.Write($"{i} ");
            }
        }
        static void EJER_5()
        {
            Console.WriteLine("\n--- GENERANDO NÚMEROS PARES DEL 1 HASTA EL 100 ---");
            Console.WriteLine("\n--------------------------");

            for (int i = 2; i <= 100; i += 2)
            {
                Console.Write($"{i} ");
            }
        }
        static void EJER_6()
        {
            Console.WriteLine("\n--- GENERANDO SECUENCIA NUMÉRICA DEL 100 AL 1---");
            Console.WriteLine("\n--------------------------");

            for (int i = 100; i >= 1; i -= 1)
            {
                Console.Write($"{i} ");
            }
        }
        static void EJER_7()
        {
            Console.WriteLine("\n--- GENERANDO SECUENCIA NUMÉRICA ---");
            Console.WriteLine("\n--------------------------");

            for (int i = 3; i <= 94; i += 7)
            {
                Console.Write($"{i} ");
            }
        }
        static void EJER_8()
        {
            Console.WriteLine("\n--- GENERANDO SECUENCIA NUMÉRICA ---");
            Console.WriteLine("\n--------------------------");

            for (int i = 1; i <= 100; i ++)
            {
                if ( i % 3 == 0)
                {
                    Console.WriteLine($"{i} - MÚLTIPLO DE 3");
                }
                else
                {
                     Console.WriteLine($"{i}");
                }
            }
            
        }
    }
}
