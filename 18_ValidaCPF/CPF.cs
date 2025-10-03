using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _18_ValidaCPF
{
    public class CPF : IDocumento
    {
        public string numero { get; }

        public CPF(string numero)
        {
            this.numero = Regex.Replace(numero, "[^0-9]", "");
        }

        public bool Validar()
        {
            if (numero.Length != 11 || numero.Distinct().Count() == 1)
            {
                return false;
            }

            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = numero.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            string digito = resto.ToString();
            tempCpf += digito;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            digito += resto.ToString();

            return numero.EndsWith(digito);
        }
    }
}
