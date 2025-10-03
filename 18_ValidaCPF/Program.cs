using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _18_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)


        {
            while (true)
            {
                Console.Write("Digite o seu CPF :)  : ");
                string entrada = Console.ReadLine();

                IDocumento documento = new CPF(entrada);

                if (documento.Validar())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"CPF {documento.numero} é válido!");
                    Console.ResetColor();

                    break;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"CPF {documento.numero} é inválido! Tente Novamente. \n");

                    Console.ResetColor();
                }

                Console.ResetColor();
                Console.ReadKey();
            }

           
        }
    }
}