using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11_ColecaoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            string nome;
            bool nomeCorreto = true;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Digite o {i}º nome: ");
                do
                {
                    nome = Console.ReadLine().Trim();

                    if (nome.Length < 3)
                    {
                        Console.WriteLine("Prezado usuário,\nO nome dever conter no mínimo 3 caracteres");
                        nomeCorreto = false;
                    }
                    else if (Regex.IsMatch(nome, @"(.)\1\1"))
                    {
                        Console.WriteLine("Prezado usuário,\nO nome não pode conter 3 caracteres iguais sequenciais");
                        nomeCorreto = false;
                    }
                    else
                    {
                        nomeCorreto = true;
                    }

                } while (nomeCorreto == false);

                nomes.Add(nome);
            }

            foreach (string nomeFor in nomes)
            {
                Console.WriteLine($"Nome:  {nomeFor}");
            }
        }
    }
}