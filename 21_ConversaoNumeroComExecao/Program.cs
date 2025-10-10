using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ConversaoNumeroComExecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Número Inteiro:");

            try
            {
                int numero = int.Parse(Console.ReadLine());
                int dobro = numero * 2;
                Console.WriteLine($"O Dobro do {numero} é {dobro}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor Invalido! Digite apenas número Inteiros :(" +
                    "");
            }
        }
    }
}
