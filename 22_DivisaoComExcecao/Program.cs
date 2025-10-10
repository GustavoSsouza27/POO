using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_DivisaoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite um Número Inteiro:");
                int numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o seu Segundo Número Inteiro:");
                int numero2 = int.Parse(Console.ReadLine());

                int resultado = numero1 / numero2;
                Console.WriteLine("Resultado da Divisão é: " + resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor Invalido... Digite apenas Números Inteiros :(");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro! Imposivel Dividir por 0... ");
            }
            finally
            {
                Console.WriteLine("Operaçao finalizada! Obrigado por usar o programa!!!!");
            }
        }
    }
}
