using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _24_CriandoExcecaoPersonalizada
{
  
    public class NotaInvalidaException : Exception
    {
        public NotaInvalidaException(string mensagem) : base(mensagem)
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite a nota do aluno (0 a 10): ");
                double nota = double.Parse(Console.ReadLine());

                if (nota < 0 || nota > 10)
                {
                    throw new NotaInvalidaException("A nota deve estar entre 0 e 10.");
                }

                if (nota >= 6)
                {
                    Console.WriteLine("Aluno aprovado!");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado!");
                }
            }
            catch (NotaInvalidaException)
            {
                Console.WriteLine("Erro: valor de nota inválido! A nota deve estar entre 0 e 10.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: entrada inválida! Digite um número válido.");
            }
        }
    }
}

