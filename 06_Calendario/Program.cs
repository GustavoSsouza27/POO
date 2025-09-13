using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using _06_Calendario;

namespace _09_Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Digite o mês (1..12)");
            //int mes = int.Parse( Console.ReadLine() );

            Console.Write("Digite o ano:");
            int ano = int.Parse(Console.ReadLine());

            Calendario calendario;
            for (int mes = 1; mes <= 12; mes++)
            {
                
                calendario = new Calendario(ano, mes);
                calendario.imprimirCalendario();

                Console.WriteLine("\n\n");

            }
            //Espera o usuário teclar qualquer tecla
            Console.ReadKey();


        }
    }
}
       